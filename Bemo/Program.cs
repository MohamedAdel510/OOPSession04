using Demo.Abstraction;
using Demo.OperatorOverloading;
using System.Data;

namespace Bemo
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            #region operator overloading
            //Complex c1 = new Complex() { Real = 1, Imag = 2 };
            //Complex c2 = new Complex() { Real = 1, Imag = 3 };

            //Complex c3 = c1 + c2;
            //Complex c4 = c1 + c2 + c3;

            #region Binary Operator
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine(c4 - c3);
            #endregion

            #region Unary Operator
            //Console.WriteLine(c4);
            //Console.WriteLine();
            //Console.WriteLine(c4++);
            //Console.WriteLine(c4);
            //Console.WriteLine(++c4);
            //Console.WriteLine();
            //Console.WriteLine(c4--);
            //Console.WriteLine(c4);
            //Console.WriteLine(--c4);
            #endregion

            #region Relational Operator
            //if (c1 > c2)
            //{
            //    Console.WriteLine("C1 is greater than C2");
            //}
            //else
            //    Console.WriteLine("C2 is greater than C1");
            #endregion

            #region Casting operator
            //int x = (int)c1;         // Explicit Casting
            //Console.WriteLine(x);

            //object obj = 3; // boxing  // implicit casting
            //int y = (int)obj;  // Explicit casting

            //string s = (string)c1;  
            #endregion

            #endregion

            #region Bussiness need for casting operator
            //User user = new User()
            //{
            //    Id = 1,
            //    Name = "Mohamed Adel",
            //    Email = "Moahamed@gmail.com",
            //    Password = "password",
            //    SecurityStemp = Guid.NewGuid(),
            //};

            //UserViewModel viewModel = (UserViewModel)user;
            //Console.WriteLine(viewModel.FName);
            //Console.WriteLine(viewModel.LName);
            //Console.WriteLine(viewModel.Email);
            //Console.WriteLine(viewModel.Password);
            #endregion

            #region Abstraction
            //Rect rect = new Rect(5, 10);
            //decimal RectPrimeter = rect.Primeter;
            //Console.WriteLine($"Rect Primeter: {RectPrimeter}");
            //decimal RectArea = rect.CalcArea();
            //Console.WriteLine($"Rect Area: {RectArea}");

            //Square square = new Square(4);
            //decimal SquarArea = square.CalcArea();
            //decimal SquarPrimeter = square.Primeter;
            //Console.WriteLine($"Squar Area: {SquarArea}");
            //Console.WriteLine($"Squar Primeter: {SquarPrimeter}");

            //Circle circle = new Circle(4);
            //Console.WriteLine($"Circle Primaeter: {circle.Primeter}");
            //Console.WriteLine($"Circle Area: {circle.CalcArea()}");
            #endregion


        }
    }
}
