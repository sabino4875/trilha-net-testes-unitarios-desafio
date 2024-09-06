namespace TestesUnitarios.Desafio.Console.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Opera��es com listas
    /// </summary>
    public sealed class ValidacoesLista
    {
#pragma warning disable CA1822 // Mark members as static
        /// <summary>
        /// Remove os n�meros negativos da listagem
        /// </summary>
        /// <param name="lista">Lista com n�meros</param>
        /// <returns>Lista sem os n�meros negativos</returns>
        public IEnumerable<Int32> RemoverNumerosNegativos(IEnumerable<Int32> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        /// <summary>
        /// Verifica se determinado n�mero existe na listagem
        /// </summary>
        /// <param name="lista">Lista com n�meros</param>
        /// <param name="numero">N�mero a ser localizado</param>
        /// <returns>Resultado da opera��o</returns>
        public Boolean ListaContemDeterminadoNumero(IEnumerable<Int32> lista, Int32 numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        /// <summary>
        /// Multiplica os elementos da lista por determinado n�mero
        /// </summary>
        /// <param name="lista">Lista com n�meros</param>
        /// <param name="numero">N�mero base para multiplica��o</param>
        /// <returns>A lista com os elementos multiplicados</returns>
        public IEnumerable<Int32> MultiplicarNumerosLista(IEnumerable<Int32> lista, Int32 numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        /// <summary>
        /// Maior n�mero da lista
        /// </summary>
        /// <param name="lista">Lista com n�meros</param>
        /// <returns>O maior n�mero</returns>
        public Int32 RetornarMaiorNumeroLista(IEnumerable<Int32> lista)
        {
            return lista.Max();
        }

        /// <summary>
        /// Menor n�mero da lista
        /// </summary>
        /// <param name="lista">Lista com n�meros</param>
        /// <returns>O menor n�mero</returns>
        public Int32 RetornarMenorNumeroLista(IEnumerable<Int32> lista)
        {
            return lista.Min();
        }
    }
#pragma warning restore CA1822 // Mark members as static
}
