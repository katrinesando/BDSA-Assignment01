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
        var result = Iterators.Flatten(numbers);
        // Then
        Assert.Equal(new[]{1,2,3,4,5,6,7,8,9},result);
    }
    [Fact]
    public void Return_1_3_5_Given_1_2_3_4_5()
    {
        // Given
        var numbers = new[]{1,2,3,4,5};
        bool Odd(int num) => num%2==1;
        // When
        var result = Iterators.Filter(numbers,Odd);
        // Then
        result.Should().BeEquivalentTo(new[]{1,3,5});
    }

}