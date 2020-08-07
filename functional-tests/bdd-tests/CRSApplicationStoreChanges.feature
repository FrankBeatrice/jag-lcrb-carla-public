﻿Feature: CRSApplicationStoreChanges
    As a logged in business user
    I want to submit a CRS Application for different business types
    And request a store relocation and structural change and transfer of ownership for the approved application

@e2e @cannabis @indigenousnation @crsstorechangesIN
Scenario: Indigenous Nation Cannabis Store Changes
    Given I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for an indigenous nation
    And I review the organization structure for an indigenous nation
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for an indigenous nation
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a store relocation for Cannabis
    And I request a structural change
    And I request a transfer of ownership
    And I confirm the relocation request is displayed on the dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @partnership @crsstorechangespartnership
Scenario: Partnership Cannabis Store Changes
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a partnership
    And I review the organization structure for a partnership
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a partnership
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a store relocation for Cannabis
    And I request a structural change
    And I request a transfer of ownership
    And I confirm the relocation request is displayed on the dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @privatecorporation @crsstorechangesprivcorp
Scenario: Private Corporation Cannabis Store Changes
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a private corporation
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a store relocation for Cannabis
    And I request a structural change
    And I request a transfer of ownership
    And I confirm the relocation request is displayed on the dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @publiccorporation @crsstorechangespubcorp
Scenario: Public Corporation Cannabis Store Changes
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a public corporation
    And I review the organization structure for a public corporation
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a public corporation
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a store relocation for Cannabis
    And I request a structural change
    And I request a transfer of ownership
    And I confirm the relocation request is displayed on the dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @society @crsstorechangessociety
Scenario: Society Cannabis Store Changes
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a society
    And I review the organization structure for a society
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a society
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a store relocation for Cannabis
    And I request a structural change
    And I request a transfer of ownership
    And I confirm the relocation request is displayed on the dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @soleproprietorship @crsstorechangessoleprop
Scenario: Sole Proprietorship Cannabis Store Changes
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a sole proprietorship
    And I review the organization structure for a sole proprietorship
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a sole proprietorship
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a store relocation for Cannabis
    And I request a structural change
    And I request a transfer of ownership
    And I confirm the relocation request is displayed on the dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @privatecorporation @validation
Scenario: Validation for CRS Store Relocation
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a private corporation
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I click on the Licences tab
    And I click on the relocation application link
    And I click on the Continue to Application button
    And I do not complete the application correctly
    And the expected validation errors are thrown for a store relocation application
    And the account is deleted
    Then I see the login page

@e2e @cannabis @privatecorporation @validation
Scenario: Validation for CRS Structural Change
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a private corporation
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I click on the Licences tab
    And I click on the structural change link
    And I click on the Continue to Application button
    And I do not complete the application correctly
    And the expected validation errors are thrown for a structural change application
    And the account is deleted
    Then I see the login page

@e2e @cannabis @privatecorporation @validation
Scenario: Validation for CRS Transfer of Ownership
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a private corporation
    # And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I click on the Licences tab
    And I click on the transfer of ownership link
    And I do not complete the application correctly
    And the expected validation errors are thrown for a CRS transfer of ownership
    And the account is deleted
    Then I see the login page