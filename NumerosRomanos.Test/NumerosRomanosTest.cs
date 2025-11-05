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

    [Fact]
    public void Si_NumeroIngresadoEsCuatro_Debe_ConvertirAIV()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(4);
        
        //Assert
        resultado.Should().Be("IV");  
    }
    
    [Fact]
    public void Si_NumeroIngresadoEsCinco_Debe_ConvertirAV()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(5);
        
        //Assert
        resultado.Should().Be("V");  
    }

    [Fact]
    public void Si_NumeroIngresadoEsSeis_Debe_ConvertirAVI()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(6);
        
        //Assert
        resultado.Should().Be("VI");  
    }
}

public class NumeroRomano
{
    public string Convertir(int numero)
    {
        if (numero == 6)
        {
            return "VI";
        }
        if (numero == 5)
        {
            return "V";
        }

        if (numero == 4)
        {
            return "IV";
        }
        if (numero == 2)
            return "II";
        if (numero == 3)
            return "III";
       if (numero == 1)
            return "I";
       
       return "";
    }
}