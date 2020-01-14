﻿using Figures.Exceptions;
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
    }
}