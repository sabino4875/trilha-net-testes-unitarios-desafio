namespace TestesUnitarios.Desafio.Tests;

using TestesUnitarios.Desafio.Console.Services;


/// <summary>
/// Testes dos métodos da classe ValidacoesString
/// </summary>
public class ValidacoesStringTests
{
    private readonly ValidacoesString _validacoes = new();

    /// <summary>
    /// Teste do método RetornarQuantidadeCaracteres
    /// </summary>
    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var texto = Faker.Company.Name();
        var resultadoEsperado = texto.Length;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    /// <summary>
    /// Teste do método ContemCaractere - Texto existe
    /// </summary>
    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
         var result = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(result);
    }

    /// <summary>
    /// Teste do método ContemCaractere - Texto não existe
    /// </summary>
    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = Faker.Company.Name();
        var textoProcurado = "tester01";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(resultado);
    }

    /// <summary>
    /// Teste do método TextoTerminaCom 
    /// </summary>
    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
