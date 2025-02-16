using scripting_ejercicios_diagnosticos;
using System;
namespace scripting_ejercicios_diagnosticos
{
    class SimplePrinter : AbstractSample
    {
        public SimplePrinter(string message) : base(message) { }

        public override void PrintMessage() => Console.WriteLine($"Mensaje: {GetMessage()}");
    }
}