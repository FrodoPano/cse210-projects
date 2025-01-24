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

    }

    public decimal TotalPrice(){
        return 0;
    }

    public string GetDisplayPacking(){
        return null;
    }

    public string GetDisplayShipping(){
        return null;
    }
}