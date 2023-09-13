using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests(){
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveRetornarSe4EhPar()
    {
        // Arrange
        int num = 4;

        // Act
        bool resultado = _calc.EhPar(num);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InLineData(new int[] {2,4, 6, 8, 10})]
    [InLineData(new int[] {12,14, 16, 18, 20})]
    public void DeveVerificarSeOsNumerosSaoParesERetVerdadeiro(int[] numeros)
    {
        // Act / Assert
        //bool resultado = _calc.EhPar(numeros);

        /*foreach(var item in numeros)
        {
            Assert.true(_calc.EhPar(item));
        }*/

        Assert.All(numeros, x =>Assert.True(_calc.EhPar(x)));

        //Assert
        //Assert.True(resultado);
    }
}