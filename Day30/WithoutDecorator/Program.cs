public abstract class Product
{
    public abstract decimal GetPrice();
    public virtual string GetDescription()
    {
        return "Basic Product";
    }
}

public class BasicProduct : Product
{
    public override decimal GetPrice()
    {
        return 50.0m;
    }
}

public class FastShippingProduct : Product
{
    private Product _product;

    public FastShippingProduct(Product product)
    {
        _product = product;
    }

    public override decimal GetPrice()
    {
        return _product.GetPrice() + 10.0m;
    }

    public override string GetDescription()
    {
        return $"{_product.GetDescription()}, Fast Shipping";
    }
}

public class InsuranceProduct : Product
{
    private Product _product;

    public InsuranceProduct(Product product)
    {
        _product = product;
    }

    public override decimal GetPrice()
    {
        return _product.GetPrice() + 5.0m;
    }

    public override string GetDescription()
    {
        return $"{_product.GetDescription()}, Insurance";
    }
}

public class ShoppingCart
{
    public void AddToCart(Product product)
    {
        Console.WriteLine($"Added to cart: {product.GetDescription()}, Price: ${product.GetPrice()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        // Produk dasar
        BasicProduct basicProduct = new BasicProduct();
        cart.AddToCart(basicProduct);

        // Produk dengan pengiriman cepat
        FastShippingProduct fastShippingProduct = new FastShippingProduct(basicProduct);
        cart.AddToCart(fastShippingProduct);

        // Produk dengan asuransi
        InsuranceProduct insuranceProduct = new InsuranceProduct(basicProduct);
        cart.AddToCart(insuranceProduct);

        // Produk dengan pengiriman cepat dan asuransi
        InsuranceProduct insuranceFastShippingProduct = new InsuranceProduct(fastShippingProduct);
        cart.AddToCart(insuranceFastShippingProduct);
    }
}