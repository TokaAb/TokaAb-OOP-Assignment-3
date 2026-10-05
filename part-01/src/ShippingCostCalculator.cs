namespace RefactoringLab;

public interface IShippingCostCalculator
{
    decimal Calculate(decimal weightKg);
}

public class ShippingCostCalculator
{
    private readonly IShippingCostCalculator calculator;

    public ShippingCostCalculator(IShippingCostCalculator calculator)
    {
        this.calculator = calculator;
    }

    public decimal Calculate(decimal weightKg)
    {
        return calculator.Calculate(weightKg);
    }
}

public class AramexCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}

public class FedExCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}

public class DHLCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}