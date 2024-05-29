namespace StructuralPizza
{
    internal class PizzaDecorator : IPizza
    {
        private IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string MakePizza()
        {
            return _pizza.MakePizza();
        }
    }
}
