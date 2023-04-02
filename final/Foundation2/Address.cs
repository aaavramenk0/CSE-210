public class Address
{
    private string _country;
    private string _street;
    private string _city;
    private string _state;
    public string SetAddress(string name) {
        Console.Write("Enter street: ");
        _street = Console.ReadLine();
        Console.Write("Enter city: ");
        _city = Console.ReadLine();
        Console.Write("Enter state/province: ");
        _state = Console.ReadLine();
        Console.Write("Enter country: ");
        _country = Console.ReadLine();

        return $"\n{name}\n{_street}\n{_city}, {_state}\n{_country}";
    }

    public int IsInUSA() {
        if (_country.Trim().ToLower() == "usa") {
            return 5;
        } else {
            return 35;
        }
    }
}