namespace Project_Patterns
{
    public class GlazeDecorator : IcecreamDecorator
    {
        public GlazeDecorator(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Make()
        {
            return base.Make() + " with glaze";
        }
    }
}
