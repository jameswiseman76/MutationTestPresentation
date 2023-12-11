namespace MutationTestDemos.Bugs.DuplicateCalls;

public record Customer : ICustomer
{
    public Customer(string firstName, string lastName, DateTime dateofBirth) => (FirstName, LastName, DateOfBirth) = (firstName, lastName, dateofBirth);

    public Guid Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public DateTime DateOfBirth { get; private set; }
}
