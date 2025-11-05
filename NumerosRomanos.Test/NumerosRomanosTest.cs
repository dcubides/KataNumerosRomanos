using FluentAssertions;

namespace NumerosRomanos.Test;

public class NumerosRomanosTest
{
    [Fact]
    public void Si_NumeroIngresadoEsUno_Debe_ConvertirAI()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();

        //Act
        string resultado = numeroRomano.Convertir(1);

        //Assert
        resultado.Should().Be("I");
    }
}

public class NumeroRomano
{
    public string Convertir(int numero)
    {
        return "I";
    }
}