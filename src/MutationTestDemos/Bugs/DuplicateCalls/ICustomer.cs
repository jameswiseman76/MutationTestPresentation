namespace MutationTestDemos.Bugs.DuplicateCalls;

public interface ICustomer
{
    Guid Id { get; }

    string FirstName { get; }

    string LastName { get; }

    DateTime DateOfBirth { get; }
}
