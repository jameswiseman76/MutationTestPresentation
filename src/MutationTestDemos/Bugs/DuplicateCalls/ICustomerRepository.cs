namespace MutationTestDemos.Bugs.DuplicateCalls;

public interface ICustomerRepository
{
    public Customer Add(Customer customer);

    public Customer Update(Customer customer);  // Idempotent

    public Customer QueryById(Guid customerId);
}
