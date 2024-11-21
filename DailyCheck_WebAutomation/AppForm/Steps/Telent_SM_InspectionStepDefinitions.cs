using DailyCheck_WebAutomation.AppForm.Pages;
using DailyCheck_WebAutomation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DailyCheck_WebAutomation.AppForm.Steps
{
    [Binding]
    public class Telent_SM_InspectionStepDefinitions : Base
    {
        Telent_SM_Elements Telent_SM_Elements = new Telent_SM_Elements();
        [Given(@"Launch the SM browser")]
        public void GivenLaunchTheSMBrowser()
        {
            openUrl(getConfigVal("Telent_PreProd_SM_URL"));
            if (tim > 9) LogIt("Time taken: " + tim + " seconds", logTyp.Warn);
        }

        [When(@"Enter the valid SM Email address")]
        public void WhenEnterTheValidSMEmailAddress()
        {
            typeText(Telent_SM_Elements.Emailaddress, getConfigVal("SM_Emailaddress"));
        }

        [When(@"Enter the valid SM Password")]
        public void WhenEnterTheValidSMPassword()
        {
            typeText(Telent_SM_Elements.Password, getConfigVal("SM_Password"));
        }

        [When(@"Click the Sign in button")]
        public void WhenClickTheSignInButton()
        {
            ClickEl(Telent_SM_Elements.SigninButton); wait(6);
        }

        [Then(@"Verify the SM application page contents")]
        public void ThenVerifyTheSMApplicationPageContents()
        {
            isThisShown(Telent_SM_Elements.homepage);
            Console.WriteLine("The system should display the solo homepage successfully");
        }

    }
}
