using System;
using Calculadora;
using NUnit.Framework;

namespace UnitTestCalculadora
{
    [TestFixture]

    public class CalculadoraTestes
    {
        CalculadoraSimples calculadora = new CalculadoraSimples();

        [Test]
        public void ValidaSomaCorreta()
        {
            var result = calculadora.Soma(5, 3);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void ValidaSomaIncorreta()
        {
            var result = calculadora.Soma(9, 21);
            Assert.That(result, Is.Not.EqualTo(31));
        }

        [Test]
        public void ValidaSubtracaoCorreta()
        {
            var result = calculadora.Subtracao(10, 4);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void ValidaSubtracaoCorretaNegativa()
        {
            var result = calculadora.Subtracao(5, 9);
            Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void ValidaSubtracaoIncorreta()
        {
            var result = calculadora.Subtracao(76, 5);
            Assert.That(result, Is.Not.EqualTo(70));
        }

        [Test]
        public void ValidaMultiplicacaoCorreta()
        {
            var result = calculadora.Multiplicacao(6, 7);
            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void ValidaMultiplicacaoIncorreta()
        {
            var result = calculadora.Multiplicacao(8, 7);
            Assert.That(result, Is.Not.EqualTo(55));
        }

        [Test]
        public void ValidaDivisaoCorretaInteira()
        {
            var result = calculadora.Divisao(48, 6);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void ValidaDivisaoCorretaDecimal()
        {
            var result = calculadora.Divisao(57, 8);
            Assert.That(result, Is.EqualTo(7.125));
        }

        [Test]
        public void ValidaDivisaoIncorreta()
        {
            var result = calculadora.Divisao(99, 33);
            Assert.That(result, Is.Not.EqualTo(11));
        }
    }
} 
