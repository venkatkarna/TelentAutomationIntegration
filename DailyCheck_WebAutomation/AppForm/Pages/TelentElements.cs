using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck_WebAutomation.AppForm.Pages
{
    public class TelentElements
    {
        //Telent Solo website elements
        public string userID = "//input[@id='UserName']";
        public string password = "//input[@id='Password']";
        public string submitButton = "//input[@id='LoginButton']";
        public string homepage = "//body[@id='MaterBodyId']";
        //Advanced Job Search
        public string hoverPMO = "//td[@id='ctl00_cCtrlMenu-menuItem000']";
        public string clickAdvancedJobSearch = "//*[@id='ctl00_cCtrlMenu-menuItem000-subMenu-menuItem001']";
        public string checkUI = "//div[@class='container-fluid']";
        //My Job
        public string myJobs = "//input[@title='My Jobs']";
        //Add Job
        public string addJob = "//input[@title='Add Job']";
        //Add Job screen elements
        public string contract = "//select[@id='ctl00_cphContent_JobPoolTabContainer_TabA537_ddlA537Contract']";
        public string exchangeAreaSearchIcon = "//a[@id='ctl00_cphContent_JobPoolTabContainer_TabA537_A537ExchangeSearchBox_btnSearch']";
        public string exchangeName = "//input[@id='txtSearchFor']";
        public string exchangeGetDetails = "//input[@id='btnGetDetails']";
        public string selectExchange = "//input[@id='btnSelect']";
    }
}
