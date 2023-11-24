using System;

// Component Interface
public abstract class Beverage
{
    public abstract string GetDescription();
    public abstract double GetCost();
}

// Concrete Component
public class Coffee : Beverage
{
    public override string GetDescription()
    {
        return "Coffee";
    }

    public override double GetCost()
    {
        return 2.0; // Harga dasar kopi
    }
}

// Decorator
public abstract class CondimentDecorator : Beverage
{
    protected Beverage _beverage;

    public CondimentDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription();
    }

    public override double GetCost()
    {
        return _beverage.GetCost();
    }
}

// Concrete Decorator
public class SugarDecorator : CondimentDecorator
{
    public SugarDecorator(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return $"{_beverage.GetDescription()}, Sugar";
    }

    public override double GetCost()
    {
        return _beverage.GetCost() + 0.5; // Harga gula
    }
}

// Concrete Decorator
public class MilkDecorator : CondimentDecorator
{
    public MilkDecorator(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return $"{_beverage.GetDescription()}, Milk";
    }

    public override double GetCost()
    {
        return _beverage.GetCost() + 1.0; // Harga susu
    }
}

// Concrete Decorator
public class IceDecorator : CondimentDecorator
{
    public IceDecorator(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return $"{_beverage.GetDescription()}, Ice";
    }

    public override double GetCost()
    {
        return _beverage.GetCost() + 0.7; // Harga es
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Pesan kopi tanpa tambahan
        Beverage coffee = new Coffee();
        Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

        // Pesan kopi dengan gula
        Beverage sugarCoffee = new SugarDecorator(new Coffee());
        Console.WriteLine($"Order: {sugarCoffee.GetDescription()}, Cost: ${sugarCoffee.GetCost()}");

        // Pesan kopi dengan susu dan es
        Beverage milkIceCoffee = new IceDecorator(new MilkDecorator(new Coffee()));
        Console.WriteLine($"Order: {milkIceCoffee.GetDescription()}, Cost: ${milkIceCoffee.GetCost()}");
    }
}