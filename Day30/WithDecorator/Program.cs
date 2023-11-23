// Component Interface
public abstract class Product
{
	public abstract decimal GetPrice();
}

// Concrete Component
public class BasicProduct : Product
{
	public override decimal GetPrice()
	{
		return 50.0m; // Harga dasar produk
	}
}
// Decorator
public class FastShippingDecorator : Product
{
	private Product _product;

	public FastShippingDecorator(Product product)
	{
		_product = product;
	}

	public override decimal GetPrice()
	{
		// Harga dasar produk ditambah biaya pengiriman cepat
		return _product.GetPrice() + 10.0m;
	}
}
// Decorator
public class InsuranceDecorator : Product
{
	private Product _product;

	public InsuranceDecorator(Product product)
	{
		_product = product;
	}

	public override decimal GetPrice()
	{
		// Harga dasar produk ditambah biaya asuransi
		return _product.GetPrice() + 5.0m;
	}
}

public class ShoppingCart
{
	public void AddToCart(Product product)
	{
		Console.WriteLine($"Added to cart: {product.GetType().Name}, Price: ${product.GetPrice()}");
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
		FastShippingDecorator fastShippingProduct = new FastShippingDecorator(basicProduct);
		cart.AddToCart(fastShippingProduct);

		// Produk dengan asuransi
		InsuranceDecorator insuranceProduct = new InsuranceDecorator(basicProduct);
		cart.AddToCart(insuranceProduct);

		// Produk dengan pengiriman cepat dan asuransi
		FastShippingDecorator fastShippingInsuranceProduct = new FastShippingDecorator(insuranceProduct);
		cart.AddToCart(fastShippingInsuranceProduct);
		
	}
}