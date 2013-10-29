using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerarListaDeNumeros
{
  public class GenerarListaDeNumeros
  {
    public static List<int> Juego(int numero1, int numero2)
    {
      if (numero1 <= 0 && numero2 <= 0)
        throw new ArgumentException("Números menores o iguales que cero no permitidos");
      if (numero1 > numero2) 
        throw new ArgumentException("Numero1 mayor que numero2 no permitido");
      
      var listInt = new List<int>();
      for (int i = numero1; i <= numero2; i++)
      {
        if (i % 2 != 0) listInt.Add(i * 2);
      }
      return listInt;
    }
  }
}
