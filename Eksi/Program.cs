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

            System.Threading.Thread.Sleep(100000);

            for (int j = 1; j < 5000; j++)
            {

                string t = "" + j;

                if (j == 1)
                {
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
                

                IWebElement daha_fazla_goster = driver.FindElement(By.XPath("//*[@id='profile-stats-sections']/a"));
                daha_fazla_goster.Click();                                  

                System.Threading.Thread.Sleep(6000);
            }
        }
    }
}
