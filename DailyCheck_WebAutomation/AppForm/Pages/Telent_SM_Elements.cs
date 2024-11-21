using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck_WebAutomation.AppForm.Pages
{
    public class Telent_SM_Elements
    {
        //TC001-SM Launch elements
        public string Emailaddress = "//input[@id='email_address_input']";
        public string Password = "//input[@id='password_input']";
        public string SigninButton = "//button[@id='sign_in']";
        public string homepage = "//a[@id='home-link']";
    }
}
