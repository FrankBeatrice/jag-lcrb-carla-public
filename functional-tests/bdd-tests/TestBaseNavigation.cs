﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I click on the link for (.*)")]
        public void ClickOnLink(string specificLink)
        {
            NgWebElement uiRequestedLink;
            try
            {
                uiRequestedLink = ngDriver.FindElement(By.LinkText(specificLink));
            }
            catch (Exception)
            {
                System.Threading.Thread.Sleep(3000);
                uiRequestedLink = ngDriver.FindElement(By.LinkText(specificLink));
            }
            
            uiRequestedLink.Click();
        }


        [And(@"I click on the branding change link for (.*)")]
        public void ClickOnBrandingChangeLink(string changeType)
        {
            /* 
            Page Title: Licences
            */

            string nameBrandingLinkCannabis = "Request Store Name or Branding Change";
            string nameBrandingLinkCateringMfg = "Establishment Name Change Application";

            if ((changeType == "Catering") || (changeType == "Manufacturing"))
            {
                // click on the Establishment Name Change Application link
                NgWebElement uiRequestChange = ngDriver.FindElement(By.LinkText(nameBrandingLinkCateringMfg));
                uiRequestChange.Click();
            }

            if (changeType == "Cannabis")
            {
                // click on the Request Store Name or Branding Change link
                NgWebElement uiRequestChange = ngDriver.FindElement(By.LinkText(nameBrandingLinkCannabis));
                uiRequestChange.Click();
            }
        }


        [And(@"I click on the Licences tab")]
        public void ClickLicencesTab()
        {
            string licencesLink = "Licences & Authorizations";

            // click on the Licences link
            ClickOnLink(licencesLink);
        }


        [And(@"I click on the Dashboard tab")]
        public void ClickDashboardTab()
        {
            string dashboard = "Dashboard";
            ClickOnLink(dashboard);
        }


        [And(@"I click on the button for (.*)")]
        public void ClickOnButton(string specificButton)
        {
            if (specificButton == "CRS terms and conditions")
            {
                // click on the Terms and Conditions button
                NgWebElement uiTermsAndConditions = ngDriver.FindElement(By.CssSelector("mat-expansion-panel mat-expansion-panel-header[role='button']"));
                uiTermsAndConditions.Click();
            }

            if (specificButton == "Catering terms and conditions")
            {
                // click on the Terms and Conditions button
                NgWebElement uiTermsAndConditions = ngDriver.FindElement(By.CssSelector("mat-expansion-panel mat-expansion-panel-header[role='button']"));
                uiTermsAndConditions.Click();
            }

            if (specificButton == "Confirm Organization Information is Complete")
            {
                // click on the Confirm Organization Information is Complete button
                NgWebElement uiCompleteButton = ngDriver.FindElement(By.CssSelector("app-application-licensee-changes button.btn-primary"));
                uiCompleteButton.Click();
            }

            if (specificButton == "Pay for Application")
            {
                // click on the Pay for Application button
                NgWebElement uiPayButton = ngDriver.FindElement(By.CssSelector("button.btn-primary"));
                uiPayButton.Click();
            }

            if (specificButton == "Submit Organization Information")
            {
                // click on the Submit Org Info button
                NgWebElement uiSubmitOrgInfoButton = ngDriver.FindElement(By.CssSelector("app-application-licensee-changes button.btn-primary"));
                uiSubmitOrgInfoButton.Click();
            }

            if (specificButton == "Save for Later")
            {
                // click on the Save For Later button
                NgWebElement uiSaveForLaterButton = ngDriver.FindElement(By.CssSelector("button.btn-secondary span"));
                uiSaveForLaterButton.Click();
            }

            if (specificButton == "Continue to Organization Review")
            {
                // click on the Continue to Organization Review button
                NgWebElement uiSaveForLaterButton = ngDriver.FindElement(By.CssSelector("button#continueToApp"));
                uiSaveForLaterButton.Click();
            }
        }


        [And(@"I click on the Submit button")]
        public void ClickOnSubmitButton()
        {
            NgWebElement uiSubmitButton = ngDriver.FindElement(By.CssSelector("button.btn-primary"));
            uiSubmitButton.Click();
        }


        [And(@"I click on the Continue to Application button")]
        public void ContinueToApplicationButton()
        {
            // click on the Continue to Application button
            NgWebElement uiContinueButton = ngDriver.FindElement(By.CssSelector("button#continueToApp"));
            uiContinueButton.Click();
        }


        [And(@"I click on the Review Organization Information button")]
        public void ClickReviewOrganizationInformation()
        {
            // click on the review organization information button
            NgWebElement uiOrgInfoButton = ngDriver.FindElement(By.CssSelector("button.btn-primary[routerlink='/org-structure']"));
            uiOrgInfoButton.Click();
        }


        [And(@"I click on the Complete Organization Information button")]
        public void CompleteOrgInfo()
        {
            // click on the complete organization information button
            NgWebElement uiOrgInfoButton = ngDriver.FindElement(By.CssSelector("button.btn-primary[routerlink='/org-structure']"));
            uiOrgInfoButton.Click();
        }


        [And(@"I click on the Start Application button for (.*)")]
        public void ClickStartApplication(string applicationType)
        {
            var tempTimeout = ngDriver.WrappedDriver.Manage().Timeouts().PageLoad;
            ngDriver.WrappedDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60 * 5);
            /* 
            Page Title: Welcome to Liquor and Cannabis Licensing
            */

            if (applicationType == "Catering")
            {
                // click on the Catering Start Application button
                NgWebElement uiStartAppButton = ngDriver.FindElement(By.Id("startCatering"));
                uiStartAppButton.Click();
            }

            if (applicationType == "a Cannabis Retail Store")
            {
                // click on the Cannabis Start Application button
                NgWebElement uiStartAppButton = ngDriver.FindElement(By.CssSelector("button[id='startCRS']"));
                uiStartAppButton.Click();
            }

            if (applicationType == "a Rural Agency Store")
            {
                // click on the Rural Store Start Application button
                NgWebElement uiStartAppButton = ngDriver.FindElement(By.CssSelector("button[id='startRAS']"));
                uiStartAppButton.Click();
            }

            if (applicationType == "a Manufacturer Licence")
            {
                // click on the Manufacturer Licence Start Application button
                NgWebElement uiStartAppButton = ngDriver.FindElement(By.CssSelector("button[id='startMfg']"));
                uiStartAppButton.Click();
            }

            ngDriver.WrappedDriver.Manage().Timeouts().PageLoad = tempTimeout;
        }


        public void SharedCalendarDate()
        {
            // click on the previous button
            NgWebElement uiOpenCalendarPrevious = ngDriver.FindElement(By.CssSelector(".mat-calendar .mat-calendar-previous-button"));
            uiOpenCalendarPrevious.Click();

            // click on the first day
            NgWebElement uiOpenCalendarYear = ngDriver.FindElement(By.CssSelector(".mat-calendar-content .mat-calendar-body-cell-content:first-child"));
            uiOpenCalendarYear.Click();
        }


        [And(@"the application is approved")]
        public void ApplicationIsApproved()
        {
            ngDriver.IgnoreSynchronization = true;
            var tempTimeout = ngDriver.WrappedDriver.Manage().Timeouts().PageLoad;
            ngDriver.WrappedDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60 * 5);

            // navigate to api/applications/<Application ID>/process
            ngDriver.Navigate().GoToUrl($"{baseUri}api/applications/{applicationID}/process");

            // wait for the automated approval process to run
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'OK')]")).Displayed);

            ngDriver.IgnoreSynchronization = false;
            ngDriver.WrappedDriver.Manage().Timeouts().PageLoad = tempTimeout;
            // navigate back to Licenses tab
            ngDriver.Navigate().GoToUrl($"{baseUri}licences");
        }


        [And(@"I do not complete the application correctly")]
        public void CompleteApplicationIncorrectly()
        {
            ClickOnSubmitButton();

            //System.Threading.Thread.Sleep(5000);
        }


        [And(@"I do not complete the licence renewal application correctly")]
        public void CompleteApplicationRenewalIncorrectly()
        {
            // click on the Submit button
            NgWebElement uiSubmitButton = ngDriver.FindElement(By.CssSelector("button:nth-child(2)"));
            uiSubmitButton.Click();

            //System.Threading.Thread.Sleep(5000);
        }


        [And(@"the expiry date is changed to today")]
        public void ExpiryDateToday()
        {            
            string transferLicence = "Transfer Licence";

            // find the Transfer Licence link
            NgWebElement uiLicenceID = ngDriver.FindElement(By.LinkText(transferLicence));
            string URL = uiLicenceID.GetAttribute("href");

            // retrieve the licence ID
            string[] parsedURL = URL.Split('/');

            licenceID = parsedURL[5];

            ngDriver.IgnoreSynchronization = true;

            // navigate to api/Licenses/<Licence ID>/setexpiry
            ngDriver.Navigate().GoToUrl($"{baseUri}api/Licenses/{licenceID}/setexpiry");

            // wait for the automated expiry process to run
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'OK')]")).Displayed);

            ngDriver.IgnoreSynchronization = false;

            // navigate back to Licenses tab
            ngDriver.Navigate().GoToUrl($"{baseUri}licences");
        }


        [And(@"I show the store as open on the map")]
        public void ShowStoreOpenOnMap()
        {
            /* 
            Page Title: Licences
            Subtitle:   Cannabis Retail Store Licences
            */

            // click on the Show Store as Open on Map checkbox
            NgWebElement uiMapCheckbox = ngDriver.FindElement(By.CssSelector("mat-checkbox"));
            uiMapCheckbox.Click();
        }
    }
}
