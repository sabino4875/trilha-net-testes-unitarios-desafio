namespace TestesUnitarios.Desafio.Console.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Operações com listas
    /// </summary>
    public sealed class ValidacoesLista
    {
#pragma warning disable CA1822 // Mark members as static
        /// <summary>
        /// Remove os números negativos da listagem
        /// </summary>
        /// <param name="lista">Lista com números</param>
        /// <returns>Lista sem os números negativos</returns>
        public IEnumerable<Int32> RemoverNumerosNegativos(IEnumerable<Int32> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        /// <summary>
        /// Verifica se determinado número existe na listagem
        /// </summary>
        /// <param name="lista">Lista com números</param>
        /// <param name="numero">Número a ser localizado</param>
        /// <returns>Resultado da operação</returns>
        public Boolean ListaContemDeterminadoNumero(IEnumerable<Int32> lista, Int32 numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        /// <summary>
        /// Multiplica os elementos da lista por determinado número
        /// </summary>
        /// <param name="lista">Lista com números</param>
        /// <param name="numero">Número base para multiplicação</param>
        /// <returns>A lista com os elementos multiplicados</returns>
        public IEnumerable<Int32> MultiplicarNumerosLista(IEnumerable<Int32> lista, Int32 numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        /// <summary>
        /// Maior número da lista
        /// </summary>
        /// <param name="lista">Lista com números</param>
        /// <returns>O maior número</returns>
        public Int32 RetornarMaiorNumeroLista(IEnumerable<Int32> lista)
        {
            return lista.Max();
        }

        /// <summary>
        /// Menor número da lista
        /// </summary>
        /// <param name="lista">Lista com números</param>
        /// <returns>O menor número</returns>
        public Int32 RetornarMenorNumeroLista(IEnumerable<Int32> lista)
        {
            return lista.Min();
        }
    }
#pragma warning restore CA1822 // Mark members as static
}
