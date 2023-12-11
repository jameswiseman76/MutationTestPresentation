namespace MutationTestDemos.Bugs.DuplicateCalls;

public class CustomerServiceBase: ICustomerService
{
    protected ICustomerRepository _repository;

    public CustomerServiceBase(ICustomerRepository repository) => _repository = repository;

    public virtual void UpdateCustomer(Customer customer)
    {
        _repository.Update(customer);
    }
}
