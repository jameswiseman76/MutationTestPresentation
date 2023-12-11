using Moq;
using MutationTestDemos.Bugs.DuplicateCalls;

namespace MutationTestDemos.UnitTests.Bugs;

[TestClass]
public class DuplicateCallsTest
{
    private Mock<ICustomerRepository> _mockCustomerRepository;
    private CustomerService _underTest;

    [TestInitialize]
    public void Initialise()
    {
        _mockCustomerRepository = new Mock<ICustomerRepository>();
        _underTest = new CustomerService(_mockCustomerRepository.Object);
    }
    
    [TestMethod]
    public void UpdateCustomer_WhenPassedAValidCustomer_UpdatesExpectedCustomer()
    {
        // Arrange
        var customer = new Customer("James", "Wiseman", new DateTime(2000, 01, 01));

        // Act
        _underTest.UpdateCustomer(customer);

        // Assert
        _mockCustomerRepository.Verify(
            m => m.Update(
                It.Is<Customer>(c => c.Id == customer.Id)));

        // Notes:
        // Times.Exactly(2)
        // Not picking up missing fields: not perfect!
    }
}
