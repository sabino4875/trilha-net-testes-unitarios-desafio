namespace TestesUnitarios.Desafio.Console.Services
{
    using System;

    /// <summary>
    /// Rotinas de uso geral para uma sequencia de caracteres
    /// </summary>
    public sealed class ValidacoesString
    {
#pragma warning disable CA1822 // Mark members as static
        /// <summary>
        /// Retorna a quantidade de caracteres de um determinado texto
        /// </summary>
        /// <param name="texto">Sequencia de caracteres</param>
        /// <returns>Quantidade de caracteres</returns>
        public Int32 RetornarQuantidadeCaracteres(String texto)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(texto);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(texto);

            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        /// <summary>
        /// Verifica se determinado texto existe em uma sequencia de caracteres
        /// </summary>
        /// <param name="texto">Sequencia de caracteres</param>
        /// <param name="textoProcurado">Texto a ser procurado</param>
        /// <returns>Status da operação</returns>
        public Boolean ContemCaractere(String texto, String textoProcurado)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(texto);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(texto);

            ArgumentNullException.ThrowIfNullOrEmpty(textoProcurado);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(textoProcurado);


            var contem = texto.Contains(textoProcurado, StringComparison.OrdinalIgnoreCase);
            return contem;
        }

        /// <summary>
        /// Verifica se determinada o final de uma sequencia de caracteres é igual a um determinado texto
        /// </summary>
        /// <param name="texto">Sequencia de caracteres</param>
        /// <param name="textoProcurado">Texto a ser comparado</param>
        /// <returns>Resultado da operação</returns>
        public Boolean TextoTerminaCom(String texto, String textoProcurado)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(texto);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(texto);

            var termina = texto.EndsWith(textoProcurado, StringComparison.OrdinalIgnoreCase);
            return termina;
        }
#pragma warning restore CA1822 // Mark members as static
    }
}