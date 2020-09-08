using System.IO;
using Xunit;
namespace SystemIO.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new[] { 3, 4, 5 }, 60)]
        [InlineData(new[] { 7, 8 }, 0)]
        public void Challenge1_multiplies_3_nums_in_array_only(int[] inputArray, int expected)
        {
            //Act
            int result = Program.Challenge1(inputArray);

            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 3, 4, 5 }, 1)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1, 3, 3, 3, 3, 3 }, 3)]
        public void Challenge4_finds_most_freq(int[] arr, int expected)
        {
            //Act
            int result = Program.Challenge4(arr);

            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(new[] { 1, 5, 3, 4, 2 }, 5)]
        [InlineData(new[] { -3, -4, -5, 1 }, 1)]
        [InlineData(new[] { 5, 5, 5, 5, 5 }, 5)]
        public void Challenge5_finds_max(int[] arr, int expected)
        {
            //Act
            int result = Program.Challenge5(arr);

            //Assert
            Assert.Equal(result, expected);
        }
    }
}
