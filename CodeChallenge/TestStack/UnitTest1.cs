using InsertShift;

namespace TestStack
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("[]", true)]
        [InlineData("[", false)]
        [InlineData("[{]", false)]
        [InlineData("[{}})", false)]
        [InlineData("[{}]{}()", true)]
        public void Test_IsvalidateBrackets(string brackets, bool expected)
        {
            bool result = validateBrackets.IsvalidateBrackets(brackets);
            Assert.Equal(expected, result);
        }
    }
}