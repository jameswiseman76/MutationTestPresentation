using MutationTestDemos.Demo1;

namespace MutationTestDemos.UnitTests.Demo1;

[TestClass]
public class MathsTests
{
    public Maths _underTest = new();

    [TestMethod]
    public void Add_WhenPassedTwoIntegers_ReturnsExpectedSum()
    {
        // Arrange
        var expected = 2;

        // Act
        var actual = _underTest.Add(2, 0);

        // Asserr
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Subtract_WhenPassedTwoIntegers_ReturnsExpectedSum()
    {
        // Arrange
        var expected = 2;

        // Act
        var actual = _underTest.Subtract(2, 0);

        // Asserr
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Multiply_WhenPassedTwoIntegers_ReturnsExpectedSum()
    {
        // Arrange
        var expected = 2;

        // Act
        var actual = _underTest.Multiply(2, 1);

        // Asserr
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Divide_WhenPassedTwoIntegers_ReturnsExpectedSum()
    {
        // Arrange
        var expected = 2;

        // Act
        var actual = _underTest.Divide(2, 1);

        // Asserr
        Assert.AreEqual(expected, actual);
    }
}