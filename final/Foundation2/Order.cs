public class Order
{
    private string _customerInfo;
    private double _totalPrice;
    private List<string> products = new List<string>();
    Product product = new Product();
    Customer customer = new Customer();

    public void AddCustomer() {
        _customerInfo = customer.AddCustomer();
    }

    public void AddProduct() {
        _totalPrice += product.AddProduct();
    }
    public void GetTotalPrice() {
        int _shippingPrice = customer.IsInUSA();
        Console.WriteLine($"Products price is: ${_totalPrice}\nShipping price is: ${_shippingPrice}\nTotal price is: ${_totalPrice + _shippingPrice}");
    }
    public void GetProductsList(){
        products = product.GetProductsList();
        foreach (string product in products)
        {
            Console.WriteLine(product);
        }
    }
    public void GetShippingLabel() {
        Console.WriteLine(_customerInfo);
    }
}