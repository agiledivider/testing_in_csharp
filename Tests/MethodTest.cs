namespace Tests;

public class MethodTest
{
    [Fact]
    public void TestAMethod()
    {
        Assert.Equal(5, myMethod());
    }

    private int myMethod()
    {
        return 5;
    }
}