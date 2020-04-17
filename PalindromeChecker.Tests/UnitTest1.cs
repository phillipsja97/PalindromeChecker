using System;
using Xunit;

namespace PalindromeChecker.Tests
{
    public class palindrome_to_check
    {
        [Fact]
        public void check_on_stats()
        {
            // Arrange
            var originalString = "stats";
            var expectedResult = true;
            var stringToCheck = new Checker();

            // Act 
            var actualResult = stringToCheck.CheckPalindrome(originalString);

            // Assert
            Assert.Matches(originalString, actualResult);
        }

        [Fact]
        public void check_on_stars()
        {
            // Arrange
            var originalString = "stars";
            var expectedResult = false;
            var stringToCheck = new Checker();

            // Act 
            var actualResult = stringToCheck.CheckPalindrome(originalString);

            // Assert
            Assert.Matches(originalString, actualResult);
        }

        [Fact]
        public void check_on_really_long_phrase()
        {
            // Arrange
            var originalString = "oakakuwakovlilvokawukakao";
            var expectedResult = true;
            var stringToCheck = new Checker();

            // Act 
            var actualResult = stringToCheck.CheckPalindrome(originalString);

            // Assert
            Assert.Matches(originalString, actualResult);
        }

        [Fact]
        public void check_on_some_men_interpret_nine_memos()
        {
            // Arrange
            var originalString = "somemeninterpretninememos";
            var expectedResult = true;
            var stringToCheck = new Checker();

            // Act 
            var actualResult = stringToCheck.CheckPalindrome(originalString);

            // Assert
            Assert.Matches(originalString, actualResult);
        }
    }
}
