namespace Homework.Tests;

public class ReadLineTest
{
    [Fact(Skip = "Will be fixed later")]
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
        Assert.False(result);
    }
}