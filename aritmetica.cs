using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
        /// <summary>
        /// Implementa operações aritméticas
        /// </summary>
    internal static class aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahreneit,
            FahreneitCelcius 

        }
        /// <summary>
        /// Operação Soma
        /// </summary>
        /// <returns>Retorna Soma de dois números</returns>
            public static int Somar(int x, int y)
            {
                return x + y; 
            
            }
            /// <summary>
            /// Operação Subtração
            /// </summary>
            /// <returns>Retorna Subtração de dois número</returns>
            public static int Subtrair(int x, int y)
            {
                return x - y; 
            }
            public static double Convertertemperatura(ConversaoTemperatura, double temperatura)
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
