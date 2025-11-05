using FluentAssertions;

namespace NumerosRomanos.Test;

public class NumerosRomanosTest
{
    [Fact]
    public void Si_NumeroIngresadoEsUno_Debe_ConvertirAUno()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();

        //Act
        string resultado = numeroRomano.Convertir(1);

        //Assert
        resultado.Should().Be("1");
    }
}

public class NumeroRomano
{
    public string Convertir(int i)
    {
        throw new NotImplementedException();
    }
}