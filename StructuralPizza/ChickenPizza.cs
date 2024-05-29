namespace StructuralPizza
{
    internal class ChickenPizza : PizzaDecorator
    {
        public ChickenPizza(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return base.MakePizza() + " with chicken";
        }
    }
}
