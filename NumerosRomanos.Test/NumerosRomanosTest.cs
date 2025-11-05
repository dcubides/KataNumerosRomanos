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

    [Fact]
    public void Si_NumeroIngresadoEsDos_Debe_ConvertirAII()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(2);
        
        //Assert
        resultado.Should().Be("II");
    }
}

public class NumeroRomano
{
    public string Convertir(int numero)
    {
        return "I";
    }
}