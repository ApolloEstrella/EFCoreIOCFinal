using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;

namespace WebApplication1.ConcreteClasses
{
    public class MyDependency : IMyDependency
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage Message: {message}");
        }
        public void ReadMessage()
        {

        }
        public void ToDo()
        {

        }

        public string Comments()
        {
            return "here is my comment";
        }
    }
}
