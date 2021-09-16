namespace Composite.APP.Interface
{
    public interface ICarComponent
    {
        string NameCar { get; set; }

        void Adicionar(ICarComponent iCarComponent);
    }
}
