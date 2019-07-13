# LibraryCalc02
Biblioteca de Operações Matemáticas

[![Build status](https://ci.appveyor.com/api/projects/status/9si4xhkcfoucnw6l/branch/master?svg=true)](https://ci.appveyor.com/project/Thijapones/librarycalc02/branch/master)

## Hot to Install
Install-Package LibraryCalc02 -Version 1.0.3

## How to Use

```CS
using LibraryCalc02;
using System;

namespace Example
{
    public class Execucao
    {
        public static void Main(string[] args)
        {
            
            var calc02 = new Calc02();
            var Soma = Calc02.Soma(x, y);
            Console.WriteLine(Soma);
            
        }
     }
}
```
