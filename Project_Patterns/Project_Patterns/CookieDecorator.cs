namespace Project_Patterns
{
    public class CookieDecorator : IcecreamDecorator
    {
        public CookieDecorator(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Make()
        {
            return base.Make() + " with cookies";
        }
    }
}
