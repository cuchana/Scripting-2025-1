namespace scripting_ejercicios_diagnosticos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Loteria

            int num = 1234;


            int Resultado = 1432;


            int valorApostado = 1000;

            int premio = CalcularPremio(num, Resultado, valorApostado);
            if (num == Resultado)
            {
                Console.WriteLine("Ganaste el chance ");
            }


            if (premio > 0)
            {
                Console.WriteLine($"¡Felicidades! Usted ganó ${premio}.");
            }
            else
            {
                Console.WriteLine("Lo sentimos, no ganó esta vez.");
            }



             static int CalcularPremio(int numeroApostado, int numeroResultado, int montoApostado)
            {
                // Pasar el numero a cadena
                string num = numeroApostado.ToString("D4");
                string resultado = numeroResultado.ToString("D4");

                // Caso 1: Coincidencia exacta de las cuatro cifras
                if (num == resultado)
                {
                    return montoApostado * 4500;
                }

                // Caso 2: Coincidencia de las cuatro cifras en desorden
                if (num.OrderBy(c => c).SequenceEqual(resultado.OrderBy(c => c)))
                {
                    return montoApostado * 200;
                }

                // Caso 3: Coincidencia de las últimas tres cifras en orden
                if (num.Substring(1) == resultado.Substring(1))
                {
                    return montoApostado * 400;
                }

                // Caso 4: Coincidencia de las últimas dos cifras en orden
                if (num.Substring(2) == resultado.Substring(2))
                {
                    return montoApostado * 50;
                }

                // Caso 5: Coincidencia de la última cifra
                if (num.Substring(3) == resultado.Substring(3))
                {
                    return montoApostado * 5;
                }

                // Si no se cumple ninguna condición, no hay premio
                return 0;
            }

            // FIBONACCI
            int n = 20;

            ImprimirPrimosEnFibonacci(n);


            static void ImprimirPrimosEnFibonacci(int n)
            {
                int fib1 = 0, fib2 = 1;

                for (int i = 1; i <= n; i++)
                {
                    // Verificar si el número es primo directamente aquí
                    if (fib1 >= 2) // Los números menores a 2 no son primos
                    {
                        bool esPrimo = true;

                        for (int j = 2; j * j <= fib1; j++) // Comprobar divisores
                        {

                            if (fib1 % j == 0)
                            {
                                esPrimo = false;

                            }
                        }
                        if (esPrimo)
                        {
                            Console.WriteLine(fib1); // Imprimir si es primo
                        }
                    }
                    // Calcular el siguiente número de Fibonacci
                    int next = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = next;

                }


            }

            //Segundos a hora, minutos y segundos

            int segundos = 3665;
            string resultado = ConvertirSegundos(segundos);
            Console.WriteLine( "Resultado "+resultado);


            static string ConvertirSegundos(int segundos)
            {
                // Calcular horas, minutos y segundos
                int horas = segundos / 3600;
                int minutos = (segundos % 3600) / 60;
                int segundosRestantes = (segundos % 3600) % 60;

                // Formatear los valores como HH:MM:SS, porque el profe nos odia
                return ConvertirFormato(horas) + ":" + ConvertirFormato(minutos) + ":" + ConvertirFormato(segundosRestantes); 
            }

            static string ConvertirFormato(int numero)
            {
                if (numero < 10)
                {
                    return "0" + numero.ToString();//Lo convertimos a string para que c# no se confunda y los intente sumar al mostrarlo
                }
                else
                {
                    return numero.ToString();
                }
            }




        }
    }
}

    
