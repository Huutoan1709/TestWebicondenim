using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace _66_Toan_TestWebIcondenim
{
    [TestClass]
    public class _66_toan_TestLogin
    {
        private IWebDriver driver_66_Toan;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void Setup()
        {
            // Khởi tạo ChromeDriver
            //Tắt màn hình đen
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            driver_66_Toan = new ChromeDriver(chrome);
        }
        [TestMethod]
        public void LoginSuccess_66_toan()
        {
            // Mở trang web icondenim
            driver_66_Toan.Navigate().GoToUrl("https://icondenim.com/");

            Thread.Sleep(3000);

            //66_toan tìm phần tử login theo CssSelector 
            driver_66_Toan.FindElement(By.CssSelector(
                "#site-header-center > div > div > div.group-icon-header.pd-right-0.pd-0-mb > div" +
                " > ul > li.list-inline-item.mr-0.hidden-sm > a")).Click();
            Thread.Sleep(2000);


            //66_toan Lấy elements input phone theo ID
            driver_66_Toan.FindElement(By.Id("customer_email")).SendKeys("0961499124");

            //66_toan Lấy elements input password theo ID
            driver_66_Toan.FindElement(By.Id("customer_password")).SendKeys("Nguyenhuutoan");
            Thread.Sleep(3000);

            //66_toan Lấy elements submit
            driver_66_Toan.FindElement(By.CssSelector("#customer_login > div.action_bottom.text-center > input")).Click();

            Thread.Sleep(1500);
            driver_66_Toan.Quit();
        }


        [TestMethod]
        //66_toan kết nối data test từ file PhoneFail.csv
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"..\..\DataLogin\PhoneFail.csv", "PhoneFail#csv", DataAccessMethod.Sequential)]
        public void Checkphone_66_toan()
        {
            string phone_66_toan = TestContext.DataRow[0].ToString();
            string password_66_toan = TestContext.DataRow[1].ToString();

            // 66_toan Mở trang web icondenim
            driver_66_Toan.Navigate().GoToUrl("https://icondenim.com/");
            IWebElement getmodal_66_toan = driver_66_Toan.FindElement(By.CssSelector(
                "#site-header-center > div > div > div.group-icon-header.pd-right-0.pd-0-mb > div" +
                " > ul > li.list-inline-item.mr-0.hidden-sm > a"));
            Thread.Sleep(3000);
            getmodal_66_toan.Click();

            //66_toan nhập phone va password
            driver_66_Toan.FindElement(By.Id("customer_email")).SendKeys(phone_66_toan);
            driver_66_Toan.FindElement(By.Id("customer_password")).SendKeys(password_66_toan);
            Thread.Sleep(4000);
            //66_toan Lấy elements submit
            driver_66_Toan.FindElement(By.CssSelector("#customer_login > div.action_bottom.text-center > input")).Click();
            try
            {
                //66_toan lấy element thông báo lỗi
                IWebElement errorlogin_66_toan = driver_66_Toan.FindElement(By.CssSelector("#customer_login > div.errors"));
                if (errorlogin_66_toan.Displayed)
                {
                    string error_66_toan = errorlogin_66_toan.Text;
                    Console.WriteLine("Đã xảy ra lỗi khi đăng nhập: " + error_66_toan);
                    Assert.AreEqual("Số điện thoại không hợp lệ.", error_66_toan, "Unexpected number in the phone element");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Không có thông báo lỗi nào xảy ra!!!");
            }
            Thread.Sleep(1500);
            driver_66_Toan.Quit();
        }


        [TestMethod]
        //66_toan kết nối data test từ file LoginFail.csv
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"..\..\DataLogin\LoginFail.csv", "LoginFail#csv", DataAccessMethod.Sequential)]
        public void LoginFail_66_toan()
        {
            string phone_66_toan = TestContext.DataRow[0].ToString();
            string password_66_toan = TestContext.DataRow[1].ToString();

            // 66_toan Mở trang web icondenim
            driver_66_Toan.Navigate().GoToUrl("https://icondenim.com/");
            IWebElement getmodal_66_toan = driver_66_Toan.FindElement(By.CssSelector(
                "#site-header-center > div > div > div.group-icon-header.pd-right-0.pd-0-mb > div" +
                " > ul > li.list-inline-item.mr-0.hidden-sm > a"));
            Thread.Sleep(3000);
            getmodal_66_toan.Click();

            //66_toan nhập phone va password
            driver_66_Toan.FindElement(By.Id("customer_email")).SendKeys(phone_66_toan);
            driver_66_Toan.FindElement(By.Id("customer_password")).SendKeys(password_66_toan);
            Thread.Sleep(4000);
            //66_toan Lấy elements submit
            driver_66_Toan.FindElement(By.CssSelector("#customer_login > div.action_bottom.text-center > input")).Click();
            try
            {
                //66_toan lấy element thông báo lỗi
                IWebElement errorlogin_66_toan = driver_66_Toan.FindElement(By.CssSelector("#customer_login > div.errors"));
                if (errorlogin_66_toan.Displayed)
                {
                    string error_66toan = errorlogin_66_toan.Text;
                    Console.WriteLine("Đã xảy ra lỗi khi đăng nhập: " + error_66toan);
                    Assert.AreEqual("Thông tin đăng nhập không hợp lệ.", error_66toan);
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Không có thông báo lỗi nào xảy ra!!!");
            }
            Thread.Sleep(1500);
            driver_66_Toan.Quit();
        }

        //[TestMethod]
        //public void LoginWithNoData_66_toan()
        //{
        //    // Mở trang web icondenim
        //    driver_66_Toan.Navigate().GoToUrl("https://icondenim.com/");

        //    Thread.Sleep(3000);

        //    //66_toan tìm phần tử login theo CssSelector 
        //    driver_66_Toan.FindElement(By.CssSelector(
        //        "#site-header-center > div > div > div.group-icon-header.pd-right-0.pd-0-mb > div" +
        //        " > ul > li.list-inline-item.mr-0.hidden-sm > a")).Click();
        //    Thread.Sleep(2000);


        //    //66_toan Lấy elements input phone theo ID
        //    driver_66_Toan.FindElement(By.Id("customer_email")).SendKeys("");

        //    //66_toan Lấy elements input password theo ID
        //    driver_66_Toan.FindElement(By.Id("customer_password")).SendKeys("");
        //    Thread.Sleep(3000);

        //    //66_toan Lấy elements submit
        //    driver_66_Toan.FindElement(By.CssSelector("#customer_login > div.action_bottom.text-center > input")).Click();
        //    //66_toan Lưu url trước khi đăng nhập
        //    string urlBeforeLogin_66_toan = driver_66_Toan.Url;

        //    // 66_toan Lưu URL sau khi đăng nhập
        //    string urlAfterLogin_66_toan = driver_66_Toan.Url;

        //    // Kiểm tra xem URL có thay đổi hay không
        //    if (urlBeforeLogin_66_toan == urlAfterLogin_66_toan)
        //    {
        //        Console.WriteLine("Thất bại: URL không thay đổi sau khi đăng nhập.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Thành công: URL đã thay đổi sau khi đăng nhập.");
        //    }
        //    Thread.Sleep(1500);
        //    driver_66_Toan.Quit();
        //}

    }
}
