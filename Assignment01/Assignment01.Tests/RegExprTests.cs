namespace Assignment01.Tests;

public class RegExprTests
{
    [Fact]
    public void Regex_should_return_singular_words()
    {
        //Given
        var test = new[]{"This is","a String","of 4 words","yay"};

        //When
        var result = RegExpr.SplitLine(test);

        //Then
        result.Should().BeEquivalentTo(new[]{"This","is","a", "String", "of","4", "words","yay"});
    }
}