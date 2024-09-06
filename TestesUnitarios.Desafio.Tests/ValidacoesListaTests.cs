namespace TestesUnitarios.Desafio.Tests;

using System;
using System.Collections.Generic;
using TestesUnitarios.Desafio.Console.Services;


/// <summary>
/// Testes dos métodos da classe ValidacoesLista
/// </summary>
public class ValidacoesListaTests
{
    private readonly ValidacoesLista _validacoes = new();

    /// <summary>
    /// Teste do método RemoverNumerosNegativos
    /// </summary>
    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<Int32> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<Int32> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    /// <summary>
    /// Teste do método ListaContemUmDeterminadoNumero - Número existente
    /// </summary>
    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<Int32> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    /// <summary>
    /// Teste do Método ListaContemDeterminadoNumero - Número não existente
    /// </summary>
    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<Int32> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var result = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
        // Assert
        Assert.False(result);
    }

    /// <summary>
    /// Teste do método MultiplicarNumerosLista
    /// </summary>
    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<Int32> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<Int32> { 10, 14, 16, 18 };

        // Act
        var result = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(result, resultadoEsperado);
    }

    /// <summary>
    /// Teste do método RetornarMaiorNumeroLista
    /// </summary>
    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<Int32> { 5, -1, -8, 9 };

        // Act
        var result = _validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, result);
    }

    /// <summary>
    /// Teste do método RetornarMenorNumeroLista
    /// </summary>
    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<Int32> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}
