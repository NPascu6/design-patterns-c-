namespace StructuralPizza
{
    internal class VeggiePizza : PizzaDecorator
    {
        public VeggiePizza(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return base.MakePizza() + " with veggies";
        }
    }
}
