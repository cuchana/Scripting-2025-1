using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scripting_ejercicios_diagnosticos
{
    abstract class AbstractSample
    {
        private string message;

        public AbstractSample(string message)
        {
            this.message = message;
        }

        public abstract void PrintMessage();

        public virtual void InvertMessage()
        {
            message = new string(message.Reverse().ToArray());
            Console.WriteLine($"Mensaje invertido: {message}");
        }

        protected string GetMessage() => message;
    }
}
