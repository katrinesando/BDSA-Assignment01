namespace Assignment1.Tests;

public class IteratorsTests
{
    [Fact]
    public void Return_Single_Stream_Given_Three()
    {
        // Given
        var numbers = new List<List<int>>();
        numbers.Add(new List<int>{1,2,3});
        numbers.Add(new List<int>{4,5,6});
        numbers.Add(new List<int>{7,8,9});
        // When
        var result = Iterators.Flatten<int>(numbers);
        // Then
        Assert.Equal(new[]{1,2,3,4,5,6,7,8,9},result);
    }

}