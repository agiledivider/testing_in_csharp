namespace Tests;

public class Parameterized_Tests
{
    [Theory]
    [InlineData(1,1,2)]
    [InlineData(2,2,4)]
    [InlineData(33,33,66)]
    //[InlineData(7,3,10)]
    public void With_Inline_Data(int value1, int value2, int expected)
    {
        var sut = new Calculator();

        var result = sut.Add(value1, value2);
        
        result.Should().Be(expected);
    }
    
    [Theory (Skip = "lets see if we get this to work")]
    [MemberData(nameof(Data))]
    public void WithMemberData(int value1, int value2, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value1, value2);

        expected.Should().Be(result);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { 1, 2, 3 },
            new object[] { -4, -6, -10 },
            new object[] { -2, 2, 0 },
            new object[] { int.MinValue, -1, int.MaxValue }, //why is this a bad test
        };
}

