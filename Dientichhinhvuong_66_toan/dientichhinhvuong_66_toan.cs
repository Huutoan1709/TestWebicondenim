using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;

namespace Dientichhinhvuong_66_toan
{
    [TestClass]
    public class DienTichHinhVuong_66_toan
    {

       public double tinhdientich_66_toan(double sideLength)
        {
            if (sideLength <= 0)
            {
                return 0;
            }

            return sideLength * sideLength;
        }

        [TestMethod]
        public void TC1_66_toan_CanhHopLe()
        {
            double sideLength_66_toan = 4;
            double kq_66_toan = tinhdientich_66_toan(sideLength_66_toan);

            Console.WriteLine("Dien tich hinh vuong = " + kq_66_toan);
            //So sánh kết quả mong muốn là 16 và kết quả thực tế\
            Assert.AreEqual(16, kq_66_toan);
        }

        [TestMethod]
        public void TC2_66_toan_CanhKhongHople()
        {
            double sideLength_66_toan = -8;
            double kq_66_toan = tinhdientich_66_toan(sideLength_66_toan);
            Console.WriteLine("Dien tich hinh vuong = " + kq_66_toan);

            //So sánh kết quả mong muốn là 16 và kết quả thực tế
            Assert.AreEqual(0, kq_66_toan);
        }

    }
}
