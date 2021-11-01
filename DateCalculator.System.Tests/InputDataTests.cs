using Xunit;

namespace DateCalculator.System.Tests
{
    public class InputDataTests
    {
        [Theory]
        [InlineData("plus", "10/11/1999", "10")]
        [InlineData("divide", "25/10/1800", "1600")]
        [InlineData("anything", "10/10/2010", "1")]
        public void Should_be_returned_right_exception_when_operation_is_not_valid(string operation, string date, string amount)
        {
            #region Arrange

            var context = new DateManager(date, operation, amount);

            #endregion

            #region Act/Assert

            Assert.NotNull(context);
            Assert.Throws<InvalidInputOperationException>(() => context.ValidateDateTime());

            #endregion
        }

        [Theory]
        [InlineData("decrease", "99/99/9999", "150")]
        [InlineData("decrease", "00/00/0000", "30")]
        public void Should_be_returned_right_exception_when_date_is_not_valid(string operation, string date, string amount)
        {
            #region Arrange

            var context = new DateManager(date, operation, amount);

            #endregion

            #region Act/Assert

            Assert.NotNull(context);
            Assert.Throws<InvalidDateException>(() => context.ValidateDateTime());

            #endregion
        }

        [Theory]
        [InlineData("decrease", "-10/-25/-9999", "-100")]
        [InlineData("decrease", "anything", "aaa")]
        [InlineData("decrease", "dd/mm/yyyy", "0a")]
        [InlineData("decrease", "-1/-2/-999", "99")]
        public void Should_be_returned_right_exception_when_date_format_is_not_valid(string operation, string date, string amount)
        {
            #region Arrange

            var context = new DateManager(date, operation, amount);

            #endregion

            #region Act/Assert

            Assert.NotNull(context);
            Assert.Throws<FormatStringException>(() => context.ValidateDateTime());

            #endregion
        }
    }
}
