/// <summary>
/// Copyright by Tin Trinh @ 2020
/// Project: Web Automation using Selenium WebDriver (ChromeDriver)
/// Background knowledge: Need to have
/// - Basic C# programming skill
/// - Skill to process data using Regular Expressions in C#
/// Guide:
/// - First, please update Nuget packages (Selenium WebDriver, Selenium Chrome Driver), Google Chrome to the latest version
/// - Run the demo code below to make sure everything works fine.
/// - Contact me at trinhtrongtinpp@gmail.com
/// </summary>


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;


namespace WebAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1: Get product information
            //Usage:
            //1. Prepare product import file for Ecommerce website
            //2. Update quantity/price for Ecommerce website
            /*
            {
                //Create new browser instance using IWebDriver
                IWebDriver browser = new ChromeDriver();

                //Redirect to site by URL
                browser.Navigate().GoToUrl("https://www.sachthom.com/my-account/");
                
                //Select elements by CSS Selector (easiest way)
                //You can also select element by ID, Class, Name, XPath,...
                //Get brand by CSS Attribute Selectors (https://www.w3schools.com/css/css_attribute_selectors.asp)
                var element = browser.FindElement(By.CssSelector("[itemprop=\"brand manufacturer\"]>a"));
                var brand = element.GetAttribute("innerHTML"); //OuterHTML will give full element HTML code

                //Get price by CSS Selectors (https://www.w3schools.com/css/css_selectors.asp)
                element = browser.FindElement(By.CssSelector("#final-price")); //No timeout, wait until page loaded
                                                                               //element = browser.FindElement(By.CssSelector("#final-price"), 10); //Timeout 10 seconds
                var finalPrice = element.GetAttribute("innerHTML");

                //Close browser
                browser.Close();
            }//----------------------------------------------
            */
            //Example 2: Login a website
            //Usage: Automate website
            {
                //Create new browser instance using IWebDriver
                IWebDriver browser = new ChromeDriver();
                //IWebDriver driver = new ChromeDriver();
                //browser.Manage().Window.Maximize();
                //Redirect to site by URL
                //User/pass: admin / admin99
                browser.Navigate().GoToUrl("https://www.sachthom.com/my-account/");

                //Fill username
                var element = browser.FindElement(By.Name("username"));
                element.SendKeys("admin");

                //Fill password
                element = browser.FindElement(By.Name("password"));
                element.SendKeys("sachthomchamcom99");

                //Click login
                element = browser.FindElement(By.Name("login"));
                element.Click();
                /*
                //Redirect to site by URl
                //Filter category
                browser.Navigate().GoToUrl("https://www.sachthom.com/wp-admin/edit.php?s&post_status=all&post_type=product&action=-1&seo_filter&readability_filter&product_cat=tam-ly&product_type&stock_status&paged=1&action2=-1");
                */

                //Add internal link to content
                // category tâm lý
                //int[] index = { 4560, 4562, 4564, 4566, 4568, 4572, 4574, 4576, 4578, 4580, 4582, 4584, 4586, 4588, 4590, 4592, 4594, 4596, 4598, 4600, 4602, 4604, 4606, 4608, 4610, 4612, 4614, 4616, 4618, 4620, 4622, 4624, 4626, 4628, 4630, 4632, 4634, 4636, 4638, 4640, 4642, 4644, 4646, 4648, 4650, 4652, 4654, 4656, 4658, 4660, 4662, 4664, 4666, 4668, 4670, 4672, 4674, 4676, 4678, 4680, 4682, 4684, 4686, 4688, 4690, 4692, 4694, 4696, 4698, 4700, 4702, 4704, 4706, 4708, 4710, 4712, 4714, 4716, 4718, 4720, 4722, 4724, 4726, 4728, 4730, 4732, 4734, 4736, 4738, 4740, 4742, 4744, 4746, 4748, 4750, 4752, 4754, 4756, 4758, 4760, 4762, 4764, 4766, 4768, 4770, 4772, 4774, 4776, 4778, 4780, 4782, 4784, 4786, 4788, 4790, 4792, 4794, 4796, 4798, 4800, 4802, 4804, 4806, 4808, 4810, 4812, 4814, 4816, 4818, 4820, 4822, 4824, 4826, 4828, 4830, 4832, 4834, 4836, 4838, 4840, 4842, 4844, 4846 };
                // category tiểu thuyết
                int[] index = { 240, 242, 244 };
                //int[] index = { 5154, 5158, 5159 };
                foreach (int i in index)
                {
                    string indexurl;
                    //https://sachthom.com/wp-admin/post.php?post=4830&action=edit
                    indexurl = "https://sachthom.com/wp-admin/post.php?post=" + i.ToString() + "&action=edit";
                    browser.Navigate().GoToUrl(indexurl);
                    System.Threading.Thread.Sleep(new Random().Next(5) * 1000);
                    element = browser.FindElement(By.Id("content"));
                    // content for category tam ly
                    //element.SendKeys("<br> >>Xem thêm sách cùng thể loại <a href=\"https://www.sachthom.com/danh-muc-san-pham/tam-ly-xa-hoi/tam-ly/ \"><strong style=\"color:blue\">tại đây</strong></a>");
                    // content fot category tieu thuyet 
                    element.SendKeys("<br> >>Xem thêm sách cùng thể loại <a href=\"https://sachthom.com/danh-muc-san-pham/van-hoc/tieu-thuyet/ \"><strong style=\"color:blue\">tại đây</strong></a>");
                    System.Threading.Thread.Sleep(new Random().Next(5) * 1000);
                    ////get title text
                    //element = browser.FindElement(By.CssSelector("#title")); //No timeout, wait until page loaded
                    //                                                               //element = browser.FindElement(By.CssSelector("#final-price"), 10); //Timeout 10 seconds
                    //var titletxt = element.GetAttribute("innerHTML");
                    ////find button edit snippet
                    //element = browser.FindElement(By.CssSelector(".Button__BaseButton-grb41s-4 Button-grb41s-3 Button-grb41s-1 Button-grb41s-2 Button-grb41s-0 SnippetEditor__SnippetEditorButton-sc-1hz1x15-0 SnippetEditor__EditSnippetButton-sc-1hz1x15-1 gfGsWs"));
                    //element.Click();
                    //System.Threading.Thread.Sleep(new Random().Next(5) * 1000);
                    ////add meta title
                    //element.FindElement(By.CssSelector(".shared__InputContainer-sc-1qsmlb9-0 shared__DescriptionInputContainer-sc-1qsmlb9-3 shared-sc-1qsmlb9-1 TXMkK"));
                    //element.SendKeys(titletxt);
                    //element.FindElement(By.CssSelector(".shared__InputContainer-sc-1qsmlb9-0 shared__DescriptionInputContainer-sc-1qsmlb9-3 shared-sc-1qsmlb9-1 TXMkK"));
                    //element = browser.FindElement(By.Id("publish"));
                    //element.Click();
                    element.Submit();
                  
                    var alert_win = browser.SwitchTo().Alert();
                  
                    alert_win.Accept();
                    System.Threading.Thread.Sleep(new Random().Next(5) * 1000);
                }
                
                /*
                //Add link to description
                browser.Navigate().GoToUrl("https://www.sachthom.com/wp-admin/post.php?post=5024&action=edit");
                element = browser.FindElement(By.Id("content-html"));
                element.Click();

                element = browser.FindElement(By.Id("content"));
                element.SendKeys("<br> >>Xem thêm sách cùng thể loại <a href=\"https://www.sachthom.com/danh-muc-san-pham/tam-ly-xa-hoi/tam-ly/ \"><strong style=\"color:blue\">tại đây</strong></a>");

                element = browser.FindElement(By.Id("publish"));
                element.Click();
                */
            }//----------------------------------------------
            /*
            //Example 3: Search Google, then click link
            //Usage: Increase SEO rank, or kill component payouts
            {
                //Create new browser instance using IWebDriver
                IWebDriver browser = new ChromeDriver();

                //Redirect to site by URL
                browser.Navigate().GoToUrl("https://google.com");

                //Fill username
                var element = browser.FindElement(By.Name("q"));
                element.SendKeys("shipdongho.com");
                System.Threading.Thread.Sleep(new Random().Next(5) * 1000); //Sleep random from 1-5 seconds
                element.Submit();

                //Click link
                element = browser.FindElement(By.CssSelector("div[class=\"r\"]>a"));
                element.Click();

                //Close browser
                browser.Close();
            }//----------------------------------------------*/
        }
    }
}
