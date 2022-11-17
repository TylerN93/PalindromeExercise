using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("car", false)]
        public void MyTest(string word, bool expected)
        {
            var test = new Wordsmith();

            var actual = test.IsAPalendrome(word);

            Assert.Equal(expected, actual);




        }
    }
}
