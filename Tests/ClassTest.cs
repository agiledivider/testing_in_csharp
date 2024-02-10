namespace Tests;

public class ClassTest
{
    [Fact]
    public void TestAClass()
    {
        // arrange
        var sut = new MyTestClass();
        Assert.NotEqual(5, sut.number);

        // act
        sut.doMagic();
        
        // assert
        Assert.Equal(5, sut.number);
    }
}

public class MyTestClass
{
    public int number = 3;

    public void doMagic()
    {
        this.number += 2;
    }
}