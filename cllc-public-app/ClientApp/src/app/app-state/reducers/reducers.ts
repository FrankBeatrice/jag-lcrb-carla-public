import { MetaReducer, ActionReducer, ActionReducerMap } from '@ngrx/store';
import { AppState } from '../models/app-state';
import { environment } from '../../../environments/environment';
import * as legalEnityReducer from './legal-entities-reducer';
import * as currentAccountReducer from './current-account-reducer';
import * as currentLegalEnityReducer from './current-legal-entity-reducer';
import * as applicationsStateReducer from './indigenous-nation-reducer';
import * as currentApplicationStateReducer from './current-application-reducer';
import * as currentUserStateReducer from './current-user-reducer';
import * as ongoingLicenseeApplicationIdStateReducer from './ongoing-licensee-application-id-reducer';
import * as fileUploadsReducer from './file-uploads.reducer';


export const metaReducers: MetaReducer<AppState>[] = !environment.production
    ? [logger]
    : [];

export const reducers: ActionReducerMap<AppState> = {
    legalEntitiesState: legalEnityReducer.reducer,
    currentLegalEntityState: currentLegalEnityReducer.reducer,
    currentAccountState: currentAccountReducer.reducer,
    indigenousNationState:  applicationsStateReducer.reducer,
    currentApplicationState: currentApplicationStateReducer.reducer,
    currentUserState: currentUserStateReducer.reducer,
    onGoingLicenseeChangesApplicationIdState: ongoingLicenseeApplicationIdStateReducer.reducer,
    fileUploadsState: fileUploadsReducer.reducer
};

export function logger(reducer: ActionReducer<AppState>): ActionReducer<AppState> {
    return function (state: AppState, action: any): AppState {
        // console.log('state', state);
        return reducer(state, action);
    };
}
