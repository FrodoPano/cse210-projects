
class Product{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal TotalCost(){
        return _price * _quantity;
    }

    public override string ToString(){
        return $"{_name} (ID: {_productId}, Price: {_price:C}, Quantity: {_quantity})";
    }
}