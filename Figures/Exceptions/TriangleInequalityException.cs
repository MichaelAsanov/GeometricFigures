using System;

namespace Figures.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при нарушении неравенства треугольника
    /// </summary>
    public class TriangleInequalityException : ArgumentException
    {
        public TriangleInequalityException() : base() {}
        
        public TriangleInequalityException(string message) : base(message) {}
    }
}