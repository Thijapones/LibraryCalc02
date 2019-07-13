using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc02
{
    public class Functions
    {
        public static string Operador(string sinal)
        {
            //Adição
            if (sinal == "+")
            {
                Console.WriteLine("Selecione a primeira parcela da adição: (Somente Números Inteiros até 2.147.483.648)");
                var parcela1 = Console.ReadLine();
                if (int.TryParse(parcela1, out int result))
                {
                    Console.WriteLine("Selecione a segunda parcela da adição: (Somente Números Inteiros até 2.147.483.648)");
                    var parcela2 = Console.ReadLine();
                    if (int.TryParse(parcela2, out int result1))
                    {
                        try
                        {
                            var somatoria = Calc02.Soma(result, result1);
                            return Convert.ToString(somatoria);
                        }
                        catch
                        {
                            return "Estouro de valores";
                        }
                    }
                    else
                    {
                        return "Erro fatal: Valor selecionado inválido.";
                    }
                }
                else
                {
                    return "Erro fatal: Valor selecionado inválido.";
                }
            }
            //Subtração
            else if (sinal == "-")
            {
                Console.WriteLine("Selecione o minuendo da subtração: (Somente Números Inteiros até 2.147.483.648)");
                var minuendo = Console.ReadLine();
                if (int.TryParse(minuendo, out int result))
                {
                    Console.WriteLine("Selecione o subtraendo da subtração: (Somente Números Inteiros até 2.147.483.648)");
                    var subtraendo = Console.ReadLine();
                    if (int.TryParse(subtraendo, out int result1))
                    {
                        try
                        {
                            var diferenca = Calc02.Subtracao(result, result1);
                            return Convert.ToString(diferenca);
                        }
                        catch
                        {
                            return "Estouro de valores";
                        }
                    }
                    else
                    {
                        return "Erro fatal: Valor selecionado inválido.";
                    }
                }
                else
                {
                    return "Erro fatal: Valor selecionado inválido.";
                }
            }
            //Multiplicação
            else if (sinal == "*")
            {
                Console.WriteLine("Selecione o fator da multiplicação: (Somente Números Inteiros até 2.147.483.648)");
                var fator = Console.ReadLine();
                if (int.TryParse(fator, out int result))
                {
                    Console.WriteLine("Selecione o multiplicando da multiplicação: (Somente Números Inteiros até 2.147.483.648)");
                    var multiplicando = Console.ReadLine();
                    if (int.TryParse(multiplicando, out int result1))
                    {
                        try
                        {
                            var produto = Calc02.Multiplicacao(result, result1);
                            return Convert.ToString(produto);
                        }
                        catch
                        {
                            return "Estouro de valores";
                        }
                    }
                    else
                    {
                        return "Erro fatal: Valor selecionado inválido.";
                    }
                }
                else
                {
                    return "Erro fatal: Valor selecionado inválido.";
                }
            }
            //Divisão
            else if (sinal == "/")
            {
                Console.WriteLine("Selecione o dividendo da divisão: (Somente Números Inteiros até 2.147.483.648)");
                var dividendo = Console.ReadLine();
                if (int.TryParse(dividendo, out int result))
                {
                    Console.WriteLine("Selecione o divisor da divisão: (Somente Números Inteiros até 2.147.483.648)");
                    var divisor = Console.ReadLine();
                    if (int.TryParse(divisor, out int result1))
                    {
                        try
                        {
                            var quociente = Calc02.Divisao(result, result1);
                            return Convert.ToString(quociente);
                        }
                        catch
                        {
                            return "Estouro de valores";
                        }
                    }
                    else
                    {
                        return "Erro fatal: Valor selecionado inválido.";
                    }
                }
                else
                {
                    return "Erro fatal: Valor selecionado inválido.";
                }
            }
            else
            {
                throw new Exception("Falha crítica.");
            }
        }
    }
}

