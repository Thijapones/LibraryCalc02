using System;

namespace LibraryCalc02
{
    public class Programa
    {

        /// <summary>
        /// Método Principal
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de operação: (+, -, * ou /).");
            var oper = Console.ReadLine();
            while (oper != "+" && oper != "-" && oper != "*" && oper != "/")
            {
                Console.WriteLine("Selecione o tipo de operação: (+, -, * ou /).");
                oper = Console.ReadLine();
            }

            var retorno = Functions.Operador(oper);
            Console.WriteLine(retorno);
        }
    }
}

