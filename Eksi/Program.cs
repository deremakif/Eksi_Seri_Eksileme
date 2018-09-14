using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Eksi
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://eksisozluk.com/giris");
            // Waiting users for logging in and going to hater's page. 
            System.Threading.Thread.Sleep(100000);
            
            // In Eski Sozluk, the most entry owner writer has less than 50000 entries.
            for (int j = 1; j < 5000; j++)
            {

                string t = "" + j;

                if (j == 1)
                {
                    // Clicking first ten entries does no needs to showMore web element. 
                    for (int i = 1; i < 11; i++)
                    {
                        string s = "" + i;

                        IWebElement dislike = driver.FindElement(By.XPath("//*[@id='profile-stats-section-content']/div/div[" + s + "]/ul/li/footer/div[1]/span[2]/a[2]"));
                        dislike.Click();

                        System.Threading.Thread.Sleep(5000);

                    }
                }
                else
                {
                    for (int i = 1; i < 11; i++)
                    {
                        string s = "" + i;
                        
                        IWebElement dislike = driver.FindElement(By.XPath("//*[@id='profile-stats-section-content']/div[" + t + "]/div[" + s + "]/ul/li/footer/div[1]/span[2]/a[2]"));
                        dislike.Click();

                        System.Threading.Thread.Sleep(5000);

                    }
                }
                

                IWebElement showMore = driver.FindElement(By.XPath("//*[@id='profile-stats-sections']/a"));
                showMore.Click();                                  

                System.Threading.Thread.Sleep(6000);
            }
        }
    }
}
