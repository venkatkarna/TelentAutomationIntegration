using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCheck_WebAutomation.AppForm.Pages.PMO
{
    public class PMO_Elements
    {
        //Telent Solo website elements
        public string userID = "//input[@id='UserName']";
        public string password = "//input[@id='Password']";
        public string submitButton = "//input[@id='LoginButton']";
        public string homepage = "//body[@id='MaterBodyId']";

        //PMO
        public string hoverPMO = "//td[@id='ctl00_cCtrlMenu-menuItem000']";

        //PMO_ValidationJobQueue
        public string clickValidationJobQueue = "//*[@id='ctl00_cCtrlMenu-menuItem000-subMenu-menuItem000']";
        public string checkValidationJobQueueUI = "//div[@class='container-fluid']";
        public string clickeBusinessCheckbox = "//input[@id='ctl00_cphContent_eBusinessCheckBox']";
        public string selectWorkstream = "//select[@id='ctl00_cphContent_ddlWorkstream']";
        public string clickGetDetailsButton = "//input[@id='ctl00_cphContent_btnGetDetails']";
        public string verifyValidationJobQueueResults = "//table[@id='ctl00_cphContent_SearchGrid']";
        public string clickResetButton = "//input[@id='ctl00_cphContent_btnClear']";
        public string CheckResetScreen = "//input[@id='ctl00_cphContent_eBusinessCheckBox']";
        public string ClickExportViewToExcelButton = "//input[@id='ctl00_cphContent_btnExportToExcel']";
        public string SelectAnyRecord = "//span[@id='ctl00_cphContent_SearchGrid_ctl02_lblOrderNo']";
        public string ClickViewButton = "//input[@id='ctl00_cphContent_btnView']";
        public string ClickExitButton = "//input[@id='ctl00_cphContent_btnExit']";

        //PMO_Advanced Job Search
        public string clickAdvancedJobSearch = "//*[@id='ctl00_cCtrlMenu-menuItem000-subMenu-menuItem001']";
        public string checkAdvancedJobSearchUI = "//div[@class='container-fluid']";
        public string clickeBusCheckbox = "//input[@id='ctl00_cphContent_ChkeBus']";
        public string verifyAdvancedJobSearchResults = "//table[@id='ctl00_cphContent_SearchGrid']";
        public string clickClearButton = "//input[@id='ctl00_cphContent_btnClearSearch']";
        public string verifyClearedSearchCriteria = "//input[@id='ctl00_cphContent_btnClearSearch']";
        public string clickMyJobButton = "//input[@id='ctl00_cphContent_btnMyJobs']";
        public string verifyMyJobResults = "//input[@id='ctl00_cphContent_btnMyJobs']";
        public string clickAddJobButton = "//input[@id='ctl00_cphContent_btnNAddJobs']";
        public string verifyAddJobScreen = "//div[@id='ctl00_cphContent_tdloaddisable']";
        public string selectFirstJob = "//table[@id='ctl00_cphContent_SearchGrid']/tbody/tr[2]";
        public string clickCopyJobButton = "//input[@id='ctl00_cphContent_btnCopyJobs']";
        public string WindowTitleCopyJob = "//head//title";
        public string selectDepot = "//select[@id='ddlDepot']";
        public string clickCopyButton = "//input[@id='btnCopyJobs']";
        public string verifyCopyJobScreen = "//td[contains(normalize-space(text()),'Job Info')]";



    }
}
