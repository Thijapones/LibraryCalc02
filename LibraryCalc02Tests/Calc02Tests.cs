using LibraryCalc02;
using System;
using Xunit;

namespace LibraryCalc02Tests
{
    public class Calc02Tests
    {
        [Theory]
        [InlineData(1,2)]
        [InlineData(10,2)]

        public void TesteSoma(int x,int y)
        {
            var Soma = Calc02.Soma(x, y);

            Assert.True((x + y) == Soma);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 2)]
        public void TesteSub(int x, int y)
        {
            var Sub = Calc02.Subtracao(x, y);

            Assert.True((x - y) == Sub);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 2)]
        public void TesteMult(int x, int y)
        {
            var Mult = Calc02.Multiplicacao(x, y);

            Assert.True((x * y) == Mult);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 2)]
        public void TesteDiv(int x, int y)
        {
            var Div = Calc02.Divisao(x, y);

            Assert.True((x / (double)y) == Div);
        }
    }
}
