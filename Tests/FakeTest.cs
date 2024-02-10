using NSubstitute;

namespace Tests;

public class FakeTest
{
    [Fact]
    public void WithAMock()
    {

        IMinuteGiver fakeMinuteGiver = Substitute.For<IMinuteGiver>();
        fakeMinuteGiver.Minute().Returns(21);
        var sut = new WeirdCalculator(fakeMinuteGiver);

        var result = sut.AddMinutes(22);
        
        Assert.Equal(43, result);

    }

    [Fact]
    public void WithAStub()
    {
        var sut = new WeirdCalculator(new FakeMinuteGiver(21));

        var result = sut.AddMinutes(22);
        
        Assert.Equal(43, result);
    }
}

class WeirdCalculator(IMinuteGiver minuteGiver)
{
    public int AddMinutes(int number)
    {
        return number + minuteGiver.Minute();
    }
}

public interface IMinuteGiver
{
    public int Minute();
}

internal class FakeMinuteGiver(int minute) : IMinuteGiver
{
    public int Minute()
    {
        return minute;
    }
}