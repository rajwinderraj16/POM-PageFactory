using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageFactorywithPageObject
{
    public class Login
    {
        IWebDriver driver;
       
        public Login(IWebDriver driver)
        {

            this.driver = driver;
            
        }
        //lambda expression of pagefactory


        IWebElement FirstName => driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
        IWebElement LastName => driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));

        IWebElement Address => driver.FindElement(By.XPath("//textarea[@ng-model='Adress']"));
        IWebElement Emailaddress => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Phone => driver.FindElement(By.XPath("//input[@type='tel']"));
        IWebElement Gender => driver.FindElement(By.XPath("//label[1]//input[1]"));
        IWebElement Hobbies => driver.FindElement(By.XPath("//input[@id='checkbox2']"));
        
        IWebElement Skills => driver.FindElement(By.XPath("//select[@id='Skills']//option[4]"));
        IWebElement Country => driver.FindElement(By.XPath("//option[contains(text(),'Mexico')]"));
        //IWebElement SelectCountry => driver.FindElement(By.XPath("//span[contains(text(),'India')]"));
        IWebElement year => driver.FindElement(By.XPath("//option[contains(text(),'1987')]"));
        IWebElement month => driver.FindElement(By.XPath("//option[contains(text(),'March')]"));
        IWebElement day => driver.FindElement(By.XPath("//select[@id='daybox']//option[contains(text(),'17')]"));
        IWebElement password => driver.FindElement(By.XPath("//input[@id='firstpassword']"));
        IWebElement confirmpass => driver.FindElement(By.XPath("//input[@id='secondpassword']"));
        IWebElement savebutton => driver.FindElement(By.XPath("//button[@id='submitbtn']"));




        public void RegisterUser()
        {
            Thread.Sleep(2000);
            FirstName.SendKeys("Rajwinder");

            Thread.Sleep(2000);
            LastName.SendKeys("kaur");

            Thread.Sleep(2000);
            Address.SendKeys("coates road");

            Thread.Sleep(2000);
            Emailaddress.SendKeys("kaur123@gmail.com");

            Thread.Sleep(2000);
            Phone.SendKeys("1231232323");

            Thread.Sleep(2000);
            Gender.Click();

            Thread.Sleep(2000);
            Hobbies.Click();

            
            Thread.Sleep(2000);
            Skills.Click();

            Thread.Sleep(2000);
            Country.Click();

           // Thread.Sleep(3000);
           // SelectCountry.Click();

            Thread.Sleep(2000);
            year.Click();

            Thread.Sleep(2000);
            month.Click();

            Thread.Sleep(2000);
            day.Click();

            Thread.Sleep(2000);
            savebutton.Click();

            Thread.Sleep(2000);
            password.SendKeys("AAbb12");

            Thread.Sleep(2000);
            confirmpass.SendKeys("AAbb12");

            Thread.Sleep(2000);
            savebutton.Click();

        }
    }
}












