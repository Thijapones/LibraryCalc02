using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc02
{
    public class Calc02 : ICalc02
    {
        //Soma
        public static long Soma(int a, int b)
        {
            return a + b;
        }
        //Soma com 3 parcelas
        public static long Soma(int a, int b, int c)
        {
            return a + b + c;
        }
        //Subtração
        public static long Subtracao(int a, int b)
        {
            return a - b;
        }
        //Subtração com dois subtraendos
        public static long Subtracao(int a, int b, int c)
        {
            return a - b - c;
        }
        //Multiplicação
        public static long Multiplicacao(int a, int b)
        {
            return a * b;
        }
        //Divisão
        public static double Divisao(int a, int b)
        {
            return a / (double)b;
        }
    }
}
