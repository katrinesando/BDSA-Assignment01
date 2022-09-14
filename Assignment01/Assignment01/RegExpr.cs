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
                yield return match.Groups[1].Value;
            }
        }
    }

    public static IEnumerable<(int width, int height)> Resolution(string resolutions) => throw new NotImplementedException();

    public static IEnumerable<string> InnerText(string html, string tag) => throw new NotImplementedException();
}