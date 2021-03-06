import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { forkJoin, Subscription } from 'rxjs';
import { ApplicationDataService } from '@app/services/application-data.service';
import { LicenseDataService } from '@app/services/license-data.service';
import { Router } from '@angular/router';
import { Application } from '@models/application.model';
import { ApplicationSummary } from '@models/application-summary.model';
import { ApplicationTypeNames } from '@models/application-type.model';
import { Account } from '@models/account.model';
import { FeatureFlagService } from '@services/feature-flag.service';
import { FormBase } from '@shared/form-base';
import { takeWhile } from 'rxjs/operators';
import { ApplicationLicenseSummary } from '@models/application-license-summary.model';
import { FormBuilder, FormGroup } from '@angular/forms';
import { LicenceEventsService } from '@services/licence-events.service';


export const UPLOAD_FILES_MODE = 'UploadFilesMode';
export const CRS_RENEWAL_LICENCE_TYPE_NAME = 'crs';
export const LIQUOR_RENEWAL_LICENCE_TYPE_NAME = 'liquor';


const ACTIVE = 'Active';
const RENEWAL_DUE = 'Renewal Due';

@Component({
  selector: 'app-licences',
  templateUrl: './licences.component.html',
  styleUrls: ['./licences.component.scss']
})
export class LicencesComponent extends FormBase implements OnInit {
  applications: ApplicationSummary[] = [];
  mainForm: FormGroup;

  readonly ACTIVE = ACTIVE;
  readonly RENEWAL_DUE = RENEWAL_DUE;

  busy: Subscription;
  @Input() applicationInProgress: boolean;
  @Input() account: Account;
  @Output() marketerApplicationExists: EventEmitter<boolean> = new EventEmitter<boolean>();
  dataLoaded = false;
  ApplicationTypeNames = ApplicationTypeNames;
  licenceMappings = {};

  // note, in order for a licence type to show on the dashboard, they must be configured here:
  supportedLicenceTypes = [
    "Catering", "Wine Store", "Cannabis Retail Store", "Marketing",
    "Operated - Wine Store", "Operated - Catering",
    "Transfer in Progress - Wine Store", "Transfer in Progress - Catering",
    "Manufacturer", "Transfer in Progress - Manufacturer", "Operated - Manufacturer",
    "Licensee Retail Store", "Transfer in Progress - Licensee Retail Store","Operated - Licensee Retail Store",
    "UBrew and UVin", "Transfer in Progress - UBrew and UVin", "Operated - UBrew and UVin",
    "Section 119 Authorization"
  ];

  constructor(
    private applicationDataService: ApplicationDataService,
    private licenceDataService: LicenseDataService,
    private router: Router,
    public featureFlagService: FeatureFlagService,
    private licenceEventsService: LicenceEventsService,
    public fb: FormBuilder) {
    super();
    this.mainForm = new FormGroup({});
  }

  ngOnInit() {
    this.displayApplications();
  }

  /**
   *
   * */
  private displayApplications() {
    this.busy =
      forkJoin(this.applicationDataService.getAllCurrentApplications(),
        this.licenceDataService.getAllCurrentLicenses(),
        this.licenceDataService.getAllOperatedLicenses()
      ).pipe(takeWhile(() => this.componentActive))
        .subscribe(([applications, licenses, operatedLicences]) => {
          this.applications = applications;
          operatedLicences.forEach(licence => {
            licence.isOperated = true;
            licence.licenceTypeName = 'Operated - ' + licence.licenceTypeName;
          });
          const combinedLicences = [...licenses, ...operatedLicences];
          combinedLicences.forEach((licence: ApplicationLicenseSummary) => {
            licence.headerRowSpan = 1;
            this.addOrUpdateLicence(licence);
          });
        });
  }

  uploadMoreFiles(application: Application) {
    this.router.navigate([`/application/${application.id}`, { mode: UPLOAD_FILES_MODE }]);
  }

  addOrUpdateLicence(licence: ApplicationLicenseSummary) {
    licence.actionApplications = [];
    const relatedApplications = this.applications.filter(l => l.licenceId === licence.licenseId);
    relatedApplications.forEach(app => {
      const action = {
        applicationId: app.id,
        applicationTypeName: app.applicationTypeName,
        applicationStatus: app.applicationStatus,
        isPaid: app.isPaid
      };
      licence.actionApplications.push(action);
    });
    if (this.licenceTypeHasEvents(licence.licenceTypeName)) {
      licence.eventsBusy = forkJoin([
        this.licenceEventsService.getLicenceEventsList(licence.licenseId, 20)
      ])
        .subscribe(data => {
          licence.events = data[0];
          if (licence.events.length > 0) {
            licence.headerRowSpan += 1;
          }
        });
    }

    if (typeof this.licenceMappings[licence.licenceTypeName] === 'undefined') {
      this.licenceMappings[licence.licenceTypeName] = [];
    }
    const licenceIndex = this.licenceMappings[licence.licenceTypeName].findIndex(l => l.licenseId === licence.licenseId);
    if (licenceIndex >= 0) {
      this.licenceMappings[licence.licenceTypeName][licenceIndex] = licence;
    } else {
      this.licenceMappings[licence.licenceTypeName].push(licence);
    }
  }

  licenceTypeHasEvents(licenceType: string) {
    return licenceType.indexOf('Catering') >= 0 || licenceType.indexOf('Wine Store') >= 0 || licenceType.indexOf('Manufacturer') >= 0;
  }

  getNumberOfLicences() {
    return Object.keys(this.licenceMappings).length;
  }

  LicenceTypeSupported(licenceType: string) {
    const supported = this.supportedLicenceTypes.indexOf(licenceType) >= 0;
    return supported;
  }
}
