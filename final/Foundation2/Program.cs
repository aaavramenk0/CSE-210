using System;

class Program
{
    static void Main(string[] args)
    {
        int _userChoice = 0;
        Order order = new Order();
        while(_userChoice != 6) {
            Console.Write("Menu:\n1. Add customer \n2. Add product \n3. Show the list \n4. Get shipping label \n5. Get total price \n6. Quit\nChoose the action from the list: ");
            _userChoice = int.Parse(Console.ReadLine());
            
            switch(_userChoice) {
                case 1:
                    order.AddCustomer();
                    break;
                case 2:
                    order.AddProduct();
                    break;
                case 3:
                    order.GetProductsList();
                    break;
                case 4:
                    order.GetShippingLabel();
                    break;
                case 5:
                    order.GetTotalPrice();
                    break;
                case 6:
                    break;
            }
        }
    }
}