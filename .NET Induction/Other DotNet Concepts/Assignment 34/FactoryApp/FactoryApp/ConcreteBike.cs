
namespace FactoryApp
{
    class ConcreteBike : Bike
    {
        int speed = 10;
        public override int Speed
        {
            get { return speed; }
        }
    }
}
