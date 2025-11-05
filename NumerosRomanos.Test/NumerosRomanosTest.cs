using FluentAssertions;

namespace NumerosRomanos.Test;

public class NumerosRomanosTest
{
    [Fact]
    public void Si_NumeroIngresadoEsCero_Debe_ConvertirAVacio()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(0);
        
        //Assert
        resultado.Should().Be(""); 
    }
    
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

    [Fact]
    public void Si_NumeroIngresadoEsTres_Debe_ConvertirAIII()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(3);
        
        //Assert
        resultado.Should().Be("III"); 
    }
}

public class NumeroRomano
{
    public string Convertir(int numero)
    {
      
        if (numero == 2)
            return "II";
        if (numero == 3)
            return "III";
       if (numero == 1)
            return "I";
       
       return "";
    }
}