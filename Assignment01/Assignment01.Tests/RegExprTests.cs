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
        var screenRes = new[]{"1920x1080"};
        //When
        var result = RegExpr.Resolution(screenRes);
        
        //then
        var expected =new[]{(1920,1080)}; 
        result.Should().BeEquivalentTo(expected);

    }
    [Fact]
    public void Resolution_width_height_multiple_input()
    {
        //Given
        var screenRes = new[]{"1024x768", "800x600", "640x480"};
        //When
        var result = RegExpr.Resolution(screenRes);
        
        //then
        var expected = new[]{(1024,768),(800,600),(640,480)};
        result.Should().BeEquivalentTo(expected);
    } 
    [Fact]
    public void Resolution_width_height_multiple_input_single_line()
    {
        //Given
        var screenRes = new[] { "1024x768,800x600,640x480" };
        //When
        var result = RegExpr.Resolution(screenRes);
        
        //then
        var expected = new[]{(1024,768),(800,600),(640,480)};
        result.Should().BeEquivalentTo(expected);
    }
    [Fact]
    public void Html_inner_teskst(){
        //Given
        var html = "<div>Regex Text <a> This is Inner text</a> <p>This is not</p><a>More text</a></div>";

        //When
        var result = RegExpr.InnerText(html,"a");

        //Then
        var expected = new[]{" This is Inner text","More text"};
        result.Should().BeEquivalentTo(expected);

    }
   
}