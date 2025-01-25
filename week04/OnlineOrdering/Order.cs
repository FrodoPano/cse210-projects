class Order {
    private List<Product> _products;
    private Customer _customer;
    private decimal _domesticShipping;
    private decimal _internationalShipping;

    public Order(Customer customer, decimal domesticShipping, decimal internationalShipping){
        _customer = customer;
        _products = new List<Product>();
        _domesticShipping = domesticShipping;
        _internationalShipping = internationalShipping;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public decimal TotalPrice(){
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        total += _customer.GetCountry().ToUpper() == "USA" ? _domesticShipping : _internationalShipping;
        return total;
    }

    public string GetDisplayPacking(){
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"- {product}\n";
        }
        return label;
    }

    public string GetDisplayShipping(){
        return $"Shipping Label:\n{_customer}";
    }
}