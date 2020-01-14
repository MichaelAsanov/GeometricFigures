using System;
using NUnit.Framework;

namespace Figures.Test
{
    /// <summary>
    /// Тестовый класс для класса <see cref="Circle"/> 
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
        /// Передаем отрицательный радиус;
        /// Ожидаем, что произошло исключение
        /// </summary>
        [Test]
        public void ConstructorTest_NegativeRadius_Exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(-1);
            });
        }
    }
}