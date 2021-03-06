using FluentAssertions;
using Geometry.App.Validation;
using Xunit;

namespace Geometry.App.Tests;

public class InputValidatorTests
{
    [Theory]
    [InlineData("1", true)]
    [InlineData("-1", false)]
    [InlineData("0", false)]
    [InlineData("", false)]
    [InlineData("asdf", false)]
    [InlineData(null, false)]
    public void Given_input_string_When_entering_triangle_side_Then_validate_the_string_to_be_a_value(string input, bool output)
    {
        // Arrange & Act
        var result = InputValidator.IsValidTriangleSide(input);

        // Assert
        result.Should().Be(output);
    }
}