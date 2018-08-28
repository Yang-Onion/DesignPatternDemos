namespace AbstractFactory.Sample
{
    public  abstract class AbstractFactory
    {
        public abstract Bonus CreateBonus();

        public abstract Tax CreateTax();
    }
}
