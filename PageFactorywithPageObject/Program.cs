using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageFactorywithPageObject 
{
   
    [TestFixture]
   public class Program 
    {

        IWebDriver driver;
        
        
        [SetUp]
            public void LauchWebPage()
            { 
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");

            }
        [Test]
        public void TestLogin()
        {
            
            Login lg = new Login(driver);
            lg.RegisterUser();
        }

            [Test]
            public void Testtable()
            { 
                Table table = new Table(driver);
                table.tab();

            }
            
           
        }

    }








