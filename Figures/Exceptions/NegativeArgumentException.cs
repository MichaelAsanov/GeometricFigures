using System;

namespace Figures.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при передаче отрицательных аргументов
    /// </summary>
    public class NegativeArgumentException : ArgumentException
    {
        public NegativeArgumentException() : base() {}
        
        public NegativeArgumentException(string message) : base(message) {}
    }
}