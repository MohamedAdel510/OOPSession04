using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface1.Part02Q03
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Iam Sms Notfication Service \nIam sending To: {recipient}\nMessage: {message}");
        }
    }
}
