using Assignment_Interface1.Part_02;
using Assignment_Interface1.Part02Q02;
using Assignment_Interface1.Part02Q03;

namespace Assignment_Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            // Q1- c) To declare abstract methods and properties

            // Q2- d) public

            // Q3- b) No

            // Q4- b) Yes, interfaces can inherit from multiple interfaces

            // Q5- d) implements

            // Q6- b) No

            // Q7- b) No, all members are implicitly public

            // Q8- b) To provide a clear separation between interface and class members

            // Q9- b) No, interfaces cannot have constructors

            // 10- c) By separating interface names with commas
            #endregion

            #region Part 02
            #region Q1
            //IShape circle = new Circle(2);
            //circle.DisplayShapeInfo();

            //IShape rectangle = new Rectangle(4, 5);
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Q2
            //IAuthenticationService authService = new BasicAuthentictionService();
            //if (authService.AuthenticateUser("MohamedAdel", "Mohamed123"))
            //    Console.WriteLine("User Authenticated successfully.");
            //else
            //    Console.WriteLine("Fiald Authentication.");

            //if (authService.AuthrizeUser("MohamedAdel", "Admin"))
            //    Console.WriteLine("Authrized User.");
            //else
            //    Console.WriteLine("Not Authrized user");
            #endregion

            #region Q3
            EmailNotificationService e = new EmailNotificationService();
            e.SendNotification("Moahmed", "Hello, Mohamed!");
            Console.WriteLine();

            PushNotificationService P = new PushNotificationService();
            P.SendNotification("Nourhan", "Hello, Nowara!");
            Console.WriteLine();

            SmsNotificationService S = new SmsNotificationService();
            S.SendNotification("Sara", "Hello, Sara!");
            Console.WriteLine();

            #endregion

            #endregion

        }
    }
}
