using scripting_ejercicios_diagnosticos;
using System;
namespace scripting_ejercicios_diagnosticos
{
    class ImpresoraSencilla : AbstractSample
    {
        public ImpresoraSencilla(string message) : base(message) { }

        public override void PrintMessage() => Console.WriteLine($"Mensaje: {GetMessage()}");
    }
}