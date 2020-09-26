using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{
    public interface IMyDependency
    {
        void WriteMessage(string message);
        void ReadMessage();
        void ToDo();
        string Comments();
    }
}
