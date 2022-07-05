namespace BasicTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var foo = "bar";
        Assert.Equal("bar", foo);
    }
}
