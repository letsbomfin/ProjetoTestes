using System;
using Calculadora;
using NUnit.Framework;

namespace UnitTestCalculadora
{
    [TestFixture]

    public class CalculadoraTestes
    {

        [Test]
        public void ValidaSomaCorreta()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Soma(5, 3);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void ValidaSomaIncorreta()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Soma(9, 21);
            Assert.That(result, Is.Not.EqualTo(31));
        }

        [Test]
        public void ValidaSubtracaoCorreta()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Subtracao(10, 4);
            NUnit.Framework.Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void ValidaSubtracaoCorretaNegativa()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Subtracao(5, 9);
            NUnit.Framework.Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void ValidaSubtracaoIncorreta()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Subtracao(76, 5);
            NUnit.Framework.Assert.That(result, Is.Not.EqualTo(70));
        }

        [Test]
        public void ValidaMultiplicacaoCorreta()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Multiplicacao(6, 7);
            NUnit.Framework.Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void ValidaMultiplicacaoIncorreta()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Multiplicacao(8, 7);
            NUnit.Framework.Assert.That(result, Is.Not.EqualTo(55));
        }

        [Test]
        public void ValidaDivisaoCorretaInteira()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Divisao(48, 6);
            NUnit.Framework.Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void ValidaDivisaoCorretaDecimal()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Divisao(57, 8);
            NUnit.Framework.Assert.That(result, Is.EqualTo(7.125));
        }

        [Test]
        public void ValidaDivisaoIncorreta()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();

            var result = calculadora.Divisao(99, 33);
            NUnit.Framework.Assert.That(result, Is.Not.EqualTo(11));
        }
    }
} 
