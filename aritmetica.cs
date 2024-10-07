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
             /// <summary>
            /// Operação Multiplicação
            /// </summary>
            /// <returns>Retorna a Multiplicação de dois número</returns> 
            public static int Multiplicar(int x, int y)
            {
                return x * y; 
            }
    }
}
