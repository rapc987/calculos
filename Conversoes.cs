using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
        /// <summary>
        /// Implementa operações de conversão
        /// </summary>
    internal static class Conversoes
    {
    public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahreneit,
            FahreneitCelcius 

        }
    /// <summary>
    /// Conversão de Temperaturas
    /// </summary>
    /// <param name="conversao">A Conversão a efetuar</param>
    /// <param name="temperatura">A temperatura a Converter</param>
    /// <returns>Retorna o Resultado da Conversão</returns>
    public static double ConverterTemperatura(ConversaoTemperatura, double temperatura)
            {
                if(conversao == ConversaoTemperatura.CelsiusFahreneit )
                {
                    return (temperatura * 1.8000 + 32);
                }
                else if(conversao == ConversaoTemperatura.FahreneitCelcius )
                {
                    return ((temperatura = 1.8000 - 32)/1.8000);
                }

                return -1; 
            }
    }
}
        /// <summary>