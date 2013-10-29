using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GenerarListaDeNumeros;

namespace GenerarListaDeNumerosTest
{
  [TestFixture]
  public class GenerarListaDeNumerosTest
  {
    [Test]
    public void ShouldExceptionWhenNumbersAreLessOrEqualZero() 
    {
      var exception = Assert.Throws<ArgumentException>(() => GenerarListaDeNumeros.GenerarListaDeNumeros.Juego(-1,-1));
      Assert.That(exception, Has.Message.EqualTo("Números menores o iguales que cero no permitidos"));

      exception = Assert.Throws<ArgumentException>(() => GenerarListaDeNumeros.GenerarListaDeNumeros.Juego(0,-1));
      Assert.That(exception, Has.Message.EqualTo("Números menores o iguales que cero no permitidos"));
    }
    [Test]
    public void ShouldExceptionWhenNumber1GreatNumber2() 
    {
      var exception = Assert.Throws<ArgumentException>(() => GenerarListaDeNumeros.GenerarListaDeNumeros.Juego(2, 1));
      Assert.That(exception, Has.Message.EqualTo("Numero1 mayor que numero2 no permitido"));

      exception = Assert.Throws<ArgumentException>(() => GenerarListaDeNumeros.GenerarListaDeNumeros.Juego(101, 100));
      Assert.That(exception, Has.Message.EqualTo("Numero1 mayor que numero2 no permitido"));
    }
    [Test]
    public void WhenNumber1_1_Number2_1_Return_2() 
    {
      var result = GenerarListaDeNumeros.GenerarListaDeNumeros.Juego(1, 1);
      List<int> expected = new List<int> { 2 };
      Assert.AreEqual(expected, result);
    }
    [Test]
    public void WhenNumber1_1_Number2_2_Return_2()
    {
      var result = GenerarListaDeNumeros.GenerarListaDeNumeros.Juego(1, 2);
      List<int> expected = new List<int> { 2 };
      Assert.AreEqual(expected, result);
    }
    [Test]
    public void WhenNumber1_1_Number2_3_Return_2_6()
    {
      var result = GenerarListaDeNumeros.GenerarListaDeNumeros.Juego(1, 3);
      List<int> expected = new List<int> { 2, 6 };
      Assert.AreEqual(expected, result);
    }
    [Test]
    public void WhenNumber1_2_Number2_11_Return_6_10_14_18_22()
    {
      var result = GenerarListaDeNumeros.GenerarListaDeNumeros.Juego(2, 11);
      List<int> expected = new List<int> { 6, 10, 14, 18, 22 };
      Assert.AreEqual(expected, result);
    }
  }
}
