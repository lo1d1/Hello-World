namespace Homework.Tests;

public class ReadLineTest
{
    [Fact(Skip = "Will be fixed later or now")]
    public void ReadLine_Int()
    {
        var result = NumbersExtensions.ReadLine();
    }

    [Fact]
    public void IsEven_Returns_True()
    {
        // Arrange - подготовка данных
        var number = 2;

        // Act - выполнение действия
        var result = NumbersExtensions.IsEven(number);

        // Assert - проверка утверждений
        Assert.True(result);
    }
    
    [Fact]
    public void IsEven_Returns_Fails()
    {
        // Arrange - подготовка данных
        var number = 3;

        // Act - выполнение действия
        var result = NumbersExtensions.IsEven(number);

        // Assert - проверка утверждений
        Assert.False(result);
    }
}