using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc02
{
    public class ICalc02
    {
        public interface ICalc
        {
            long Soma(int a, int b);
            long Subtracao(int a, int b);
            long Multiplicacao(int a, int b);
            double Divisao(int a, int b);
        }
    }
}
