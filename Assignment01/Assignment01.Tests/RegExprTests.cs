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

    [Fact]
    public void Resolution_width_height_single_input()
    {
        //Given
        var screenRes = "1920x1080";
        //When
        var result = RegExpr.Resolution(screenRes);
        
        //then
        result.Should().BeEquivalentTo(1920,1080);
    }
    [Fact]
    public void Resolution_width_height_multiple_input()
    {
        //Given
        var screenRes = new[]{"1024x768", "800x600", "640x480"}
        //When
        var result = RegExpr.Resolution(screenRes);
        
        //then
        result.Should().BeEquivalentTo((1024,768),(800,600),(640,480));
    } 
    [Fact]
    public void Resolution_width_height_multiple_input_single_line()
    {
        //Given
        var screenRes = new[]{"1024x768,800x600,640x480"}
        //When
        var result = RegExpr.Resolution(screenRes);
        
        //then
        result.Should().BeEquivalentTo((1024,768),(800,600),(640,480));
    }
}