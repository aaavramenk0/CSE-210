public class Product
{
    private string _name;
    private double _priceForOne;
    private double _price;
    private int _quantity;
    private int _id;

    private List<string> products = new List<string>();

    public double AddProduct() {
        Console.Write("Enter product name: ");
        _name = Console.ReadLine();
        Console.Write("Enter product quantity: ");
        _quantity = int.Parse(Console.ReadLine());
        Console.Write($"Enter product price for the 1 {_name}: ");
        _priceForOne = double.Parse(Console.ReadLine());
        _price = _priceForOne * _quantity;
        Random id = new Random();
        _id = id.Next();
        string _product = $"{_quantity} {_name} - ${_price}";
        products.Add(_product);
        Console.WriteLine($"\n > New product added! \n{_product}");

        return _price;
    }
    public List<string> GetProductsList() {
        return products;
    }

}