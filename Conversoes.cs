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
        /// Tipo de Conversões de distâncias
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros,

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
    /// <summary>
    /// Conversão de Distancias
    /// </summary>
    /// <param name="conversao">A Conversão a efetuar</param>
    /// <param name="distancia">A Distância a Converter</param>
    /// <returns>Retorna o Resultado da Conversão da distância</returns>
     public static double ConverterDistancias(ConversaoDistancia, double distancia)
            {
                if(conversao == ConversaoDistancia.MetrosMilhas)
                {
                    return (distancia * 0.0006213712);
                }
                if(conversao == ConversaoDistancia.MilhasMetros)
                {
                    return (distancia * 1609.344);
                }

                return -1; 
            }
    }
}
        /// <summary>