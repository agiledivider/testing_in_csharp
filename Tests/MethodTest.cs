namespace Tests;

public class MethodTest
{
    [Fact]
    public void TestAMethod()
    {
        Assert.Equal(5, myMethod());
        myMethod().Should().Be(5);
    }

    private int myMethod()
    {
        return 5;
    }
}