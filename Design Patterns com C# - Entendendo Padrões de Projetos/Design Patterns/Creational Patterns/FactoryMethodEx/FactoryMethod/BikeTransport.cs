namespace FactoryMethod
{
    class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
