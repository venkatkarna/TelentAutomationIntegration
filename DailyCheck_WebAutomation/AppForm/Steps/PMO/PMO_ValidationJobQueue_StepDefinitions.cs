﻿using DailyCheck_WebAutomation.AppForm.Pages;
using DailyCheck_WebAutomation.AppForm.Pages.PMO;
using DailyCheck_WebAutomation.Common;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DailyCheck_WebAutomation.AppForm.Steps.PMO
{
    [Binding]
    public class PMO_ValidationJobQueue_StepDefinitions : Base
    {
        PMO_Elements PMO_Elements = new PMO_Elements();
        [Given(@"Launch the solo browser")]
        public void GivenLaunchTheSoloBrowser()
        {
            openUrl(getConfigVal("Telent_URL"));
            if (tim > 9) LogIt("Time taken: " + tim + " seconds", logTyp.Warn);
        }

        [When(@"Enter valid solo UserID")]
        public void WhenEnterValidSoloUserID()
        {
            typeText(PMO_Elements.userID, getConfigVal("Telent_UserID"));
        }

        [When(@"Enter valid solo Password")]
        public void WhenEnterValidSoloPassword()
        {
            typeText(PMO_Elements.password, getConfigVal("Telent_Password"));
        }

        [When(@"Click Submit button")]
        public void WhenClickSubmitButton()
        {
            ClickEl(PMO_Elements.submitButton);
            implicitWait(5);
        }

        [When(@"User login with valid solo credentials")]
        public void WhenUserLoginWithValidSoloCredentials()
        {
            implicitWait(5);
            typeText(PMO_Elements.userID, getConfigVal("Telent_UserID"));
            typeText(PMO_Elements.password, getConfigVal("Telent_Password"));
            ClickEl(PMO_Elements.submitButton); implicitWait(6);
        }

        [When(@"Click ‘Validation Job Queue’ link from PMO module")]
        public void WhenClickValidationJobQueueLinkFromPMOModule()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.hoverPMO, 5);
            hoverOn(PMO_Elements.hoverPMO);
            ClickEl(PMO_Elements.clickValidationJobQueue);
        }

        [Then(@"Verify the display of Validation Job Queue screen")]
        public void ThenVerifyTheDisplayOfValidationJobQueueScreen()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.checkValidationJobQueueUI, 5);
            isThisShown(PMO_Elements.checkValidationJobQueueUI);
        }

        [Then(@"Verify the display of element in Validation Job Queue screen")]
        public void ThenVerifyTheDisplayOfElementInValidationJobQueueScreen()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.clickeBusinessCheckbox, 5);
            isThisShown(PMO_Elements.clickeBusinessCheckbox);
            explicitWaitForElementToBeVisible(PMO_Elements.selectWorkstream, 5);
            isThisShown(PMO_Elements.selectWorkstream);
        }

        [When(@"Click on eBusiness Checkbox")]
        public void WhenClickOnEBusinessCheckbox()
        {
            ClickEl(PMO_Elements.clickeBusinessCheckbox); implicitWait(5);
        }

        [When(@"Select the Workstream")]
        public void WhenSelectTheWorkstream()
        {
            ClickEl(PMO_Elements.selectWorkstream);
            SelectText(PMO_Elements.selectWorkstream, getConfigVal("Telent_Workstream"));
        }

        [Then(@"Verify the filled elements")]
        public void ThenVerifyTheFilledElements()
        {
            implicitWait(5);
            isThisShown(PMO_Elements.clickeBusinessCheckbox);
            isThisShown(PMO_Elements.selectWorkstream);
        }

        [Then(@"Click on Get Details button")]
        [When(@"Click on Get Details button")]
        public void ThenClickOnGetDetailsButton()
        {
            implicitWait(5);
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.clickGetDetailsButton); 
        }

        [Then(@"Verify the display of Results in Validation Job Queue screen")]
        public void ThenVerifyTheDisplayOfResultsInValidationJobQueueScreen()
        {
            implicitWait(5);
            isThisShown(PMO_Elements.verifyValidationJobQueueResults);
        }

        [When(@"Click on Reset button")]
        public void WhenClickOnResetButton()
        {
            implicitWait(10);
            isThisShown(PMO_Elements.clickResetButton);
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.clickResetButton);           
        }

        [Then(@"Verify the all search fields and it should be reset successfully")]
        public void ThenVerifyTheAllSearchFieldsAndItShouldBeResetSuccessfully()
        {
            implicitWait(8);
            WaitForJqueryAjax();
            isExist(PMO_Elements.CheckResetScreen);
        }

        [Then(@"Click on Export View To Excel button")]
        public void ThenClickOnExportViewToExcelButton()
        {
            implicitWait(8);
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.ClickExportViewToExcelButton);
        }

        [When(@"Click on View button")]
        public void WhenClickOnViewButton()
        {
            implicitWait(8);
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.SelectAnyRecord);
            ClickEl(PMO_Elements.ClickViewButton);
        }

        [When(@"Click on Exit button")]
        public void WhenClickOnExitButton()
        {
            implicitWait(8);
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.ClickExitButton);
        }


    }
}
