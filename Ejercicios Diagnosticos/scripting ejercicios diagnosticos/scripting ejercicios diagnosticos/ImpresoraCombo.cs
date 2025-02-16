using scripting_ejercicios_diagnosticos;
using System;
using System.Linq;
namespace scripting_ejercicios_diagnosticos
{
    class ImpresoraCombo : AbstractSample
    {
        public ImpresoraCombo(string message) : base(message) { }

        public override void PrintMessage()
        {
            string invertedCaseMessage = new string(GetMessage().Select(c => char.IsLetter(c) ?
                (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());

            Console.WriteLine($"Mensaje con mayúsculas y minúsculas invertidas: {invertedCaseMessage}");
        }

        public override void InvertMessage()
        {
            string reversedMessage = new string(GetMessage().Reverse().ToArray());
            Console.WriteLine($"Mensaje invertido : {reversedMessage}");
        }
    }
}