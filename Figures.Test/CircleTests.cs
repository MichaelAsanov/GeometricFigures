using System;
using Figures.Exceptions;
using NUnit.Framework;

namespace Figures.Test
{
    /// <summary>
    /// Тесты класса<see cref="Circle"/> 
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        /// Тестирует конструктор;
        /// Передаем положительный радиус;
        /// Ожидаем, что прошло успешно
        /// </summary>
        [Test]
        public void ConstructorTest_PositiveRadius_Success()
        {
            Assert.DoesNotThrow(() =>
            {
                var circle = new Circle(1);
            });
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Передаем нулевой радиус;
        /// Ожидаем, что прошло успешно
        /// </summary>
        [Test]
        public void ConstructorTest_ZeroRadius_Success()
        {
            Assert.DoesNotThrow(() =>
            {
                var circle = new Circle(0);
            });
        }
        
        /// <summary>
        /// Тестирует конструктор;
        /// Передаем отрицательный радиус;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_NegativeRadius_Exception()
        {
            var exception = Assert.Throws<NegativeArgumentException>(() =>
            {
                var circle = new Circle(-1);
            });
            
            Assert.AreEqual("Радиус круга не может быть отрицательным", exception.Message);
        }
        
        /// <summary>
        /// Тестирует радиус и площадь;
        /// Передаем положительный радиус;
        /// </summary>
        [Test]
        public void RadiusAndAreaTest_PositiveRadius()
        {
            var circle = new Circle(1);
            Assert.AreEqual(1, circle.Radius, 0.001);
            Assert.AreEqual(Math.PI*1, circle.Area, 0.001);
        }
        
        /// <summary>
        /// Тестирует радиус и площадь;
        /// Передаем нулевой радиус;
        /// </summary>
        [Test]
        public void RadiusAndAreaTest_ZeroRadius()
        {
            var circle = new Circle(0);
            Assert.AreEqual(0, circle.Radius, 0.001);
            Assert.AreEqual(0, circle.Area, 0.001);
        }
    }
}