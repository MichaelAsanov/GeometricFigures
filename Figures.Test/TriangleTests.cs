using System;
using Figures.Exceptions;
using NUnit.Framework;

namespace Figures.Test
{
    /// <summary>
    /// Тесты класса <see cref="Triangle"/> 
    /// </summary>
    public class TriangleTests
    {
        /// <summary>
        /// Тестирует конструктор;
        /// Передаем положительные стороны;
        /// Ожидаем, что прошло успешно
        /// </summary>
        [Test]
        public void ConstructorTest_PositiveSides_Success()
        {
            Assert.DoesNotThrow(() =>
            {
                var triangle = new Triangle(1, 1, 1);
            });
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Первая сторона отрицательная;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_ThereAreNegativeSides1_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(-1, 1, 1);
            });
            Assert.AreEqual("Переданы отрицательные стороны: a = -1. Стороны треугольника не могут быть отрицательными", exception.Message);
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Вторая сторона отрицательная;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_ThereAreNegativeSides2_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(1, -1, 1);
            });
            Assert.AreEqual("Переданы отрицательные стороны: b = -1. Стороны треугольника не могут быть отрицательными", exception.Message);
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Третья сторона отрицательная;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_ThereAreNegativeSides3_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(1, 1, -1);
            });
            Assert.AreEqual("Переданы отрицательные стороны: c = -1. Стороны треугольника не могут быть отрицательными", exception.Message);
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Некоторые стороны отрицательные;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_ThereAreNegativeSides4_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(-1, -1, 1);
            });
            Assert.AreEqual("Переданы отрицательные стороны: a = -1. b = -1. Стороны треугольника не могут быть отрицательными", exception.Message);
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Некоторые стороны отрицательные;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_ThereAreNegativeSides5_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(-1, 1, -1);
            });
            Assert.AreEqual("Переданы отрицательные стороны: a = -1. c = -1. Стороны треугольника не могут быть отрицательными", exception.Message);
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Некоторые стороны отрицательные;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_ThereAreNegativeSides6_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(1, -1, -1);
            });
            Assert.AreEqual("Переданы отрицательные стороны: b = -1. c = -1. Стороны треугольника не могут быть отрицательными", exception.Message);
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Все стороны отрицательные;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_ThereAreNegativeSides7_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(-1, -1, -1);
            });
            Assert.AreEqual("Переданы отрицательные стороны: a = -1. b = -1. c = -1. Стороны треугольника не могут быть отрицательными", exception.Message);
        }

        /// <summary>
        /// Нарушение неравенства треугольника;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_TriangleInequalityNonCompliance1_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(3, 1, 1);
            });
            Assert.AreEqual("Нарушение неравенства треугольника: a > b + c. Каждая сторона треугольника должна быть меньше суммы двух других сторон.", exception.Message);
        }
        
        /// <summary>
        /// Нарушение неравенства треугольника;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_TriangleInequalityNonCompliance2_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(1, 3, 1);
            });
            Assert.AreEqual("Нарушение неравенства треугольника: b > a + c. Каждая сторона треугольника должна быть меньше суммы двух других сторон.", exception.Message);
        }
        
        /// <summary>
        /// Нарушение неравенства треугольника;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_TriangleInequalityNonCompliance3_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var triangle = new Triangle(1, 1, 3);
            });
            Assert.AreEqual("Нарушение неравенства треугольника: c > a + b. Каждая сторона треугольника должна быть меньше суммы двух других сторон.", exception.Message);
        }
        
        /// <summary>
        /// Тестирует стороны треугольника
        /// </summary>
        [Test]
        public void SidesTest()
        {
            var triangle = new Triangle(1, 2, 3);
            
            Assert.AreEqual(1, triangle.A);
            Assert.AreEqual(2, triangle.B);
            Assert.AreEqual(3, triangle.C);
        }
        
        /// <summary>
        /// Тестирует площадь треугольника;
        /// Треугольник не вырожден
        /// </summary>
        [Test]
        public void Area_TriangleNotDegenerated_Test()
        {
            var triangle = new Triangle(1, 1, 1);
            
            Assert.AreEqual(Math.Sqrt(3) / 4, triangle.Area, 0.001);
        }
        
        /// <summary>
        /// Тестирует площадь треугольника;
        /// Треугольник вырожден в отрезок;
        /// Ожидаем, что его полщадь равна нулю
        /// </summary>
        [Test]
        public void Area_TriangleDegeneratedToLine_Test()
        {
            var triangle = new Triangle(1, 2, 3);
            
            Assert.AreEqual(0, triangle.Area, 0.001);
        }
        
        /// <summary>
        /// Тестирует площадь треугольника;
        /// Треугольник вырожден в точку;
        /// Ожидаем, что его полщадь равна нулю
        /// </summary>
        [Test]
        public void Area_TriangleDegeneratedToPoint_Test()
        {
            var triangle = new Triangle(0, 0, 0);
            
            Assert.AreEqual(0, triangle.Area, 0.001);
        }
    }
}