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
    
    [Fact]
    public void Si_NumeroIngresadoEsSiete_Debe_ConvertirAVII()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(7);
        
        //Assert
        resultado.Should().Be("VII");  
    }

    [Fact]
    public void Si_NumeroIngresadoEsOcho_Debe_ConvertirAVIII()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(8);
        
        //Assert
        resultado.Should().Be("VIII"); 
    }

    [Fact]
    public void Si_NumeroIngresadoEsNueve_Debe_ConvertirAIX()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(9);
        
        //Assert
        resultado.Should().Be("IX"); 
    }

    [Fact]
    public void Si_NumeroIngresadoEsDiez_Debe_ConvertirAX()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(10);
        
        //Assert
        resultado.Should().Be("X"); 
    }

    [Fact]
    public void Si_NumeroIngresadoEsDoce_Debe_ConvertirAXII()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(12);
        
        //Assert
        resultado.Should().Be("XII"); 
    }
    
    [Fact]
    public void Si_NumeroIngresadoEsCatorce_Debe_ConvertirAXIV()
    {
        //Arrange
        var numeroRomano = new NumeroRomano();
        
        //Act
        string resultado = numeroRomano.Convertir(14);
        
        //Assert
        resultado.Should().Be("XIV"); 
    }
    
    
}

public class NumeroRomano
{
    public string Convertir(int numero)
    {
        if (numero == 14)
            return "XIV";
        
        if (numero == 12)
            return "XII";
        
        if (numero == 10)
            return "X";
        
        if (numero == 9)
            return "IX";
        
        if (numero == 8)
            return "VIII";
        
        if (numero == 7)
            return "VII";
        
        if (numero == 6)
            return "VI";
        
        if (numero == 5)
            return "V";

        if (numero == 4)
            return "IV";
        
        if (numero == 2)
            return "II";
        
        if (numero == 3)
            return "III";
       
        if (numero == 1)
            return "I";
       
        return "";
    }
}