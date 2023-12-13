using MutationTestDemos.Demo;

namespace MutationTestDemos.UnitTests.Demo1;

[TestClass]
public class MathsTests
{
    public Maths _underTest = new();

    [TestMethod]
    public void Add_WhenPassedTwoIntegers_ReturnsExpectedSum()
    {
        // Arrange
        var expected = 3;

        // Act
        var actual = _underTest.Add(2, 1);

        // Asserr
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Subtract_WhenPassedTwoIntegers_ReturnsExpectedDifference()
    {
        // Arrange
        var expected = 1;

        // Act
        var actual = _underTest.Subtract(2, 1);

        // Asserr
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Multiply_WhenPassedTwoIntegers_ReturnsExpectedProduct()
    {
        // Arrange
        var expected = 8;

        // Act
        var actual = _underTest.Multiply(2, 4);

        // Asserr
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Divide_WhenPassedTwoIntegers_ReturnsExpectedDivision()
    {
        // Arrange
        var expected = 2;

        // Act
        var actual = _underTest.Divide(4, 2);

        // Asserr
        Assert.AreEqual(expected, actual);
    }
}