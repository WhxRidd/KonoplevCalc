using Microsoft.VisualStudio.TestTools.UnitTesting;
using KonoplevLibraryFramework;// моя библиотека

namespace KonoplevTests
{
    [TestClass]
    public class KonoplevClassTests
    {
        //сложение
        [TestMethod]
        public void test_3plus3()
        {
            dynamic result = KonoplevClass.Execute(3, '+', 3);
            Assert.AreEqual(6, result);
        }

        //вычитание
        [TestMethod]
        public void test_10minus4()
        {
            dynamic result = KonoplevClass.Execute(10, '-', 4);
            Assert.AreEqual(6, result);
        }

        //умножение
        [TestMethod]
        public void test_6times7()
        {
            dynamic result = KonoplevClass.Execute(6, '*', 7);
            Assert.AreEqual(42, result);
        }

        //деление
        [TestMethod]
        public void test_15divide3()
        {
            dynamic result = KonoplevClass.Execute(15, '/', 3);
            Assert.AreEqual(5, result);
        }

        //степень
        [TestMethod]
        public void test_2to3()
        {
            dynamic result = KonoplevClass.Execute(2, '^', 3);
            Assert.AreEqual(8, result);
        }

        //деление на ноль
        [TestMethod]
        public void test_10divide0()
        {
            dynamic result = KonoplevClass.Execute(10, '/', 0);
            Assert.AreEqual(double.PositiveInfinity, result);
        }

        //метод calculate
        [TestMethod]
        public void test_calculate_5plus3()
        {
            KonoplevClass calculator = new KonoplevClass();
            double result = calculator.Calculate(5, 3, "+");
            Assert.AreEqual(8, result);
        }
    }
}

