using DailyCheck_WebAutomation.AppForm.Pages.PMO;
using DailyCheck_WebAutomation.Common;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DailyCheck_WebAutomation.AppForm.Steps.PMO
{
    [Binding]
    public class PMO_AdvancedJobSearch_StepDefinitions : Base
    {
        PMO_Elements PMO_Elements = new PMO_Elements();
        [When(@"Click ‘Advanced Job Search’ link from PMO module")]
        public void WhenClickAdvancedJobSearchLinkFromPMOModule()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.hoverPMO, 5);
            hoverOn(PMO_Elements.hoverPMO);
            ClickEl(PMO_Elements.clickAdvancedJobSearch);
        }

        [Then(@"Verify the display of Advanced Job Search screen")]
        public void ThenVerifyTheDisplayOfAdvancedJobSearchScreen()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.checkAdvancedJobSearchUI, 5);
            isThisShown(PMO_Elements.checkAdvancedJobSearchUI);
        }

        [Then(@"Verify the display of element in Advanced Job Search screen")]
        public void ThenVerifyTheDisplayOfElementInAdvancedJobSearchScreen()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.clickeBusCheckbox, 5);
            isThisShown(PMO_Elements.clickeBusCheckbox);
            explicitWaitForElementToBeVisible(PMO_Elements.selectWorkstream, 5);
            isThisShown(PMO_Elements.selectWorkstream);
        }

        [When(@"Click on eBus Checkbox")]
        public void WhenClickOnEBusCheckbox()
        {
            ClickEl(PMO_Elements.clickeBusCheckbox); implicitWait(5);
        }

        [Then(@"Verify the filled elements in Advanced Job Search screen")]
        public void ThenVerifyTheFilledElementsInAdvancedJobSearchScreen()
        {
            implicitWait(5);
            isThisShown(PMO_Elements.clickeBusCheckbox);
            isThisShown(PMO_Elements.selectWorkstream);
        }

        [Then(@"Verify the display of Results in Advanced Job Search screen")]
        public void ThenVerifyTheDisplayOfResultsInAdvancedJobSearchScreen()
        {
            implicitWait(5);
            isThisShown(PMO_Elements.verifyAdvancedJobSearchResults);
        }

        [When(@"Click on Clear button")]
        public void WhenClickOnClearButton()
        {
            implicitWait(5);
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.clickClearButton);
        }

        [Then(@"Verify the cleared values from the Advanced Job Search screen")]
        public void ThenVerifyTheClearedValuesFromTheAdvancedJobSearchScreen()
        {
            implicitWait(8);
            WaitForJqueryAjax();
            isExist(PMO_Elements.clickeBusCheckbox);
            isExist(PMO_Elements.selectWorkstream);
        }

        [When(@"Click on My Job button")]
        public void GivenClickOnMyJobButton()
        {
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.clickMyJobButton);
        }

        [Then(@"Verify the display of jobs in Search Results grid")]
        public void ThenVerifyTheDisplayOfJobsInSearchResultsGrid()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.verifyMyJobResults, 5);
            isThisShown(PMO_Elements.verifyMyJobResults);
        }

        [When(@"Click on Add Job button")]
        public void WhenClickOnAddJobButton()
        {
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.clickAddJobButton);
        }

        [Then(@"Verify the display of Add job screen")]
        public void ThenVerifyTheDisplayOfAddJobScreen()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.verifyMyJobResults, 5);
            isThisShown(PMO_Elements.verifyMyJobResults);
        }

        [When(@"Select the first job from Search Results grid")]
        public void WhenSelectTheFirstJobFromSearchResultsGrid()
        {
            implicitWait(5);
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.selectFirstJob);
        }

        [When(@"Click on Copy Job button")]
        public void WhenClickOnCopyJobButton()
        {
            implicitWait(5);
            WaitForJqueryAjax();
            ClickEl(PMO_Elements.clickCopyJobButton);
        }

        [When(@"Click on Copy button after select the Depot from dropdown")]
        public void WhenClickOnCopyButtonAfterSelectTheDepotFromDropdown()
        {
            implicitWait(5);
            WaitForJqueryAjax();
            switchToWindowGetTitle("WindowTitle_CopyJob");
            dr.Manage().Window.Maximize();
            SelectByIndex(PMO_Elements.selectDepot, 1);
            ClickEl(PMO_Elements.clickCopyButton);
        }

        [Then(@"Verify the display of Copied Job screen")]
        public void ThenVerifyTheDisplayOfCopiedJobScreen()
        {
            GetAlertTextAndAccept(dr);
            switchToWindowGetTitle("WindowTitle_JobInfo");
            explicitWaitForElementToBeVisible(PMO_Elements.verifyCopyJobScreen, 5);
            isThisShown(PMO_Elements.verifyCopyJobScreen);
        }

        [When(@"Click on More button")]
        public void WhenClickOnMoreButton()
        {
            implicitWait(5);
            ClickEl(PMO_Elements.clickMoreButton);
        }

        [When(@"Select the Job Status as On Hold")]
        public void WhenSelectTheJobStatusAsOnHold()
        {
            implicitWait(5);
            ClickEl(PMO_Elements.selectJobStatus);
            SelectText(PMO_Elements.selectJobStatus, getConfigVal("AdvancedJobSearch_JobStatus"));
        }

        [When(@"Click on Take-off Hold button")]
        public void WhenClickOnTake_OffHoldButton()
        {
            implicitWait(5);
            ClickEl(PMO_Elements.clickTakeOffHoldButton);
        }

        [Then(@"Verify the display of Job Info screen")]
        public void ThenVerifyTheDisplayOfJobInfoScreen()
        {
            explicitWaitForElementToBeVisible(PMO_Elements.verifyJobInfoScreen, 5);
            isThisShown(PMO_Elements.verifyJobInfoScreen);
        }

        [When(@"Click on Remove Owner button")]
        public void WhenClickOnRemoveOwnerButton()
        {
            implicitWait(5);
            ClickEl(PMO_Elements.clickRemoveOwnerButton);
        }

        [Then(@"Verify the alert message and accept it")]
        public void ThenVerifyTheAlertMessageAndAcceptIt()
        {
            implicitWait(5);
            GetAlertTextAndAccept(dr);
        }

    }
    //typeText(PMO_Elements.password, getConfigVal("Telent_Password"));
}
