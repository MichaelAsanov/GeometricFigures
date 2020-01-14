using System;

namespace Figures.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при нарушении неравенства треугольника
    /// </summary>
    public class TriangleInequalityNoncomlianceException : ArgumentException
    {
        public TriangleInequalityNoncomlianceException() : base() {}
        
        public TriangleInequalityNoncomlianceException(string message) : base(message) {}
    }
}