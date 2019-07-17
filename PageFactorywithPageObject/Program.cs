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
    public class Program
    {
        public static void Main(String []args)
        {
            
            
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");


                //Login lg = new Login(driver);
                //lg.RegisterUser();

                Table table = new Table(driver);
                table.tab();

            }
        }

    }








