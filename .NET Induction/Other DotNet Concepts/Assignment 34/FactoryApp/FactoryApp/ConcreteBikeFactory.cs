
namespace FactoryApp
{
    class ConcreteBikeFactory : BikeFactory
    {
        public override Bike GetBike()
        {
            return new ConcreteBike();
        }
    }
}
