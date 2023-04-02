public class Customer
{
    private string _name;
    Address address = new Address();
    public string AddCustomer(){
        Console.Write("Enter fullname: ");
        _name = Console.ReadLine();
        
        string customerInfo = address.SetAddress(_name);
        Console.WriteLine($"\n > New customer added!{customerInfo}\n");
        return customerInfo;
    }

    public int IsInUSA() {
        return address.IsInUSA();
    }
}