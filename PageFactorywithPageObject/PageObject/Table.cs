using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageFactorywithPageObject
{
    public class Table
    {
        IWebDriver driver;


        public Table(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Initiate the Table Tab
        IWebElement tabletab => driver.FindElement(By.XPath("//a[contains(text(),'WebTable')]"));

        //Initiate the Edit Button
        IWebElement Editbtn => driver.FindElement(By.XPath("//div //i[@class='fa fa-pencil'][1]"));

        //Initiate the record textfield
        IWebElement Edit => driver.FindElement(By.XPath("//input[@type='text'][@value='Ashish1']"));

        //Initiate the save button
        IWebElement save => driver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[6]/user-click-select[1]/div[2]/save-click[1]/button[1]"));

        //Initiate the Delete button
        IWebElement delete => driver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[6]/user-click-select[1]/div[1]/del-click[1]/button[1]/i[1]"));

        //Inititiate the second Delete button
        IWebElement del => driver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[6]/user-click-select[1]/div[1]/div[1]/ul[1]/li[1]/button[1]"));

        public void tab()
        {
            //Click on the Table Tab
            tabletab.Click();
            
            //Double click on the Edit button
            Actions doubleclick = new Actions(driver);
            doubleclick.MoveToElement(Editbtn).DoubleClick().Build().Perform();

            //The other method to perform the Double Click
           //doubleclick.DoubleClick(Editbtn).Build().Perform();

            //Clear the Existing record
            Edit.Clear();

            //Enter the new record
            Edit.SendKeys("RajRaj");

            //Click on the save button
            save.Click();

            //Right click on the delete button
            Thread.Sleep(2000);
            Actions Rightclick = new Actions(driver);
            Rightclick.ContextClick(delete).Build().Perform();

            //Delete the record
            del.Click();

            //To verify if the alert is present or not
            Thread.Sleep(2000);
            try
            {
                String alt = driver.SwitchTo().Alert().Text;
                Console.WriteLine(alt);
                driver.SwitchTo().Alert().Accept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }




        }
    }
}

