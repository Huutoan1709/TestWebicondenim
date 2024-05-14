using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _66_Toan_TestWebIcondenim
{
    [TestClass]
    public class _66_Toan_TestSearch
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"..\..\DataLogin\SearchSuccess.csv", "SearchSuccess#csv", DataAccessMethod.Sequential)]
        public void SearchSuccess_66toan()
        {
            //66_toan tạo biến để đọc giá trị từu file csv
            string kw_66_toan = TestContext.DataRow[0].ToString();

            // 66_toan Mở trang web icondenim
            driver_66_Toan.Navigate().GoToUrl("https://icondenim.com/");

            //66_toan Lấy elements trường Search
            IWebElement getmodal_66_toan = driver_66_Toan.FindElement(By.XPath(
                "//*[@id=\"site-header-center\"]/div/div/div[4]/div/ul/li[1]"));
            getmodal_66_toan.Click();
            Thread.Sleep(3000);
            //66_toan lấy elements input
            IWebElement searchInput_66_toan = driver_66_Toan.FindElement(By.XPath("//*[@id=\"sticky_header\"]" +
                "/div[2]/div[1]/div/div/form/div/input[2]"));
            searchInput_66_toan.SendKeys(kw_66_toan);

            //66_toan Bắt sự kiện nhấn enter
            new Actions(driver_66_Toan).KeyDown(Keys.Enter).Build().Perform();

            //66_toan lấy element
            IWebElement searchResult_66_toan = driver_66_Toan.FindElement(By.CssSelector("#searct-template > div > div > div > div.heading-page.text-center > p"));
            Assert.IsNotNull(searchResult_66_toan, "Tìm kiếm không thành công");

            // In ra thông điệp thành công nếu kiểm tra qua
            Console.WriteLine("Tìm kiếm thành công");
            Thread.Sleep(1500);
            driver_66_Toan.Quit();
        }
        [TestMethod]
        public void SearchWithEmptyKeyword_66_toan()
        {
            // 66_toan Mở trang web icondenim
            driver_66_Toan.Navigate().GoToUrl("https://icondenim.com/");

            //66_toan Lấy elements trường Search
            IWebElement getmodal_66_toan = driver_66_Toan.FindElement(By.XPath(
                "//*[@id=\"site-header-center\"]/div/div/div[4]/div/ul/li[1]"));
            getmodal_66_toan.Click();
            Thread.Sleep(3000);
            //66_toan lấy elements input với sendkeys là rỗng
            driver_66_Toan.FindElement(By.XPath("//*[@id=\"sticky_header\"]" +
                "/div[2]/div[1]/div/div/form/div/input[2]")).SendKeys("");

            //66_toan Bắt sự kiện nhấn enter
            new Actions(driver_66_Toan).KeyDown(Keys.Enter).Build().Perform();

            //66_toan lấy element
            IWebElement searchResult_66_toan = driver_66_Toan.FindElement(By.CssSelector("#searct-template > div > div > div > div.heading-page.text-center > p"));
            Assert.IsNotNull(searchResult_66_toan, "Tìm kiếm không thành công");

            // In ra thông điệp thành công nếu kiểm tra qua
            Console.WriteLine("Tìm kiếm thành công");
            Thread.Sleep(1500);
            driver_66_Toan.Quit();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"..\..\DataLogin\SearchFail.csv", "SearchFail#csv", DataAccessMethod.Sequential)]
        public void SearchFail_66_toan()
        {
            //66_toan tạo biến để đọc giá trị từu file csv
            string kw_66_toan = TestContext.DataRow[0].ToString();

            // 66_toan Mở trang web icondenim
            driver_66_Toan.Navigate().GoToUrl("https://icondenim.com/");

            //66_toan Lấy elements trường Search
            IWebElement getmodal_66_toan = driver_66_Toan.FindElement(By.XPath(
                "//*[@id=\"site-header-center\"]/div/div/div[4]/div/ul/li[1]"));
            getmodal_66_toan.Click();
            Thread.Sleep(3000);
            //66_toan lấy elements input
            IWebElement searchInput_66_toan = driver_66_Toan.FindElement(By.XPath("//*[@id=\"sticky_header\"]" +
                "/div[2]/div[1]/div/div/form/div/input[2]"));
            searchInput_66_toan.SendKeys(kw_66_toan);

            //66_toan Bắt sự kiện nhấn enter
            new Actions(driver_66_Toan).KeyDown(Keys.Enter).Build().Perform();

            //66_toan lấy element
            IWebElement searchResult_66_toan = driver_66_Toan.FindElement(By.XPath("//*[@id=\"search\"]/div/h2"));
            if(searchResult_66_toan != null)
            {
                Console.WriteLine("Tìm kiếm không hợp lệ!!");
            }
            Thread.Sleep(2000);
            driver_66_Toan.Quit();
        }
    }
}
