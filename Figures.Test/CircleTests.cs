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
    }
}