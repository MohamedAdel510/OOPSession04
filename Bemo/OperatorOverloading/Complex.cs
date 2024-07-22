using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        // operator overloading must be non-private class member method
        #region Binary Operator + , -
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0 )+ (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
        }
        #endregion

        #region Unary Operators ++, --
        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = (c?.Imag ?? 0) + 1
            };
        }

        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) - 1,
                Imag = (c?.Imag ?? 0) - 1
            };
        }
        #endregion
         
        #region Relational Operator < , >
        public static bool operator <(Complex left, Complex right)
        {
            if(left?.Real == right?.Real)
                return left?.Imag < right?.Imag;
            else
                return left?.Real < right?.Real;
        }

        public static bool operator >(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
                return left?.Imag > right?.Imag;
            else
                return left?.Real > right?.Real;
        }
        #endregion

        #region Casting Operator
        public static explicit operator int (Complex c)
        {
            return c?.Real ?? 0;
        }
        public static implicit operator string(Complex c)
        {
            return c.ToString() ?? string.Empty;
        }
        #endregion
    }
}
