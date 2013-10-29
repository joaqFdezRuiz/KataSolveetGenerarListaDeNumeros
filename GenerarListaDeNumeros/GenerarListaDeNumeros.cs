using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerarListaDeNumeros
{
  public class GenerarListaDeNumeros
  {
    public static object Juego(int numero1, int numero2)
    {
      if (numero1 <= 0 && numero2 <= 0) {
        throw new ArgumentException("Números menores o iguales que cero no permitidos");
      }
      throw new ArgumentException("Numero1 mayor que numero2 no permitido");
      
    }
  }
}
