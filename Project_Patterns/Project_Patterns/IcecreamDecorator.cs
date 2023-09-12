namespace Project_Patterns
{
    public abstract class IcecreamDecorator : IceCream
    {
        protected IceCream iceCream;

        public IcecreamDecorator(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }

        public override string Make()
        {
            return iceCream.Make();
        }
    }
}
