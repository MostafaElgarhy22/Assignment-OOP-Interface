using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_Interface.Q_3
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
