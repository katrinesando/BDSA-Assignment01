namespace Assignment01;

using System.Text.RegularExpressions;
public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines){
        var pattern = @"[a-zA-Z0-9]+";
        var regExpr = new Regex(pattern);
        foreach(var line in lines){
            
            foreach (Match match in regExpr.Matches(line))
            {
                yield return match.Groups[0].Value;
            }
        }
    }

    public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions) {
        var pattern = @"(?<width>\d+)x(?<height>\d+)";
        var reg = new Regex(pattern);
        int newHeight,newWidth;
        foreach(var line in resolutions){
            foreach(Match m in reg.Matches(line)){
                int.TryParse(m.Groups["width"].Value, out newWidth);
                int.TryParse(m.Groups["height"].Value, out newHeight);
                yield return (newWidth,newHeight);
            }
        }
    }

    public static IEnumerable<string> InnerText(string html, string tag) {
        var pattern = $@"(?<opening><{tag}(.*?)>)(?<inner>(\w+|[0-9]| +)+)(?<closing></{tag}>)";
        var reg = new Regex(pattern);

        foreach (Match m in reg.Matches(html))
        {
            yield return m.Groups["inner"].Value;
        }
    }

    public static IEnumerable<(Uri url, string title)> Urls(string html){
        var pattern = @"(?<beginURL>href="")(?<url>[^"" ][^""]*)"" (title=""(?<title>[^"" ][^""]*)""?)";
        var reg = new Regex(pattern);
        foreach (Match m in reg.Matches(html))
        {
            if(m.Groups["title"] != null){
                yield return (new Uri(m.Groups["url"].Value),m.Groups["title"].Value);
            }else{
                yield return (new Uri(m.Groups["url"].Value),"");
            }
            
        }

    }
}