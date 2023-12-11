namespace MutationTestDemos.Bugs.DuplicateCalls;

public class CustomerService : CustomerServiceBase, ICustomerService
{
    public CustomerService(ICustomerRepository repository) : base(repository)
    {
    }

    public override void UpdateCustomer(Customer customer)
    {
        base.UpdateCustomer(customer);
        _repository.Update(customer);
    }
}
