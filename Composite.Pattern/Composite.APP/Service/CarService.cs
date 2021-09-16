using Composite.APP.Interface;
using System;

namespace Composite.APP.Service
{
    public class CarService : ICarComponent
    {
        public CarService(string nameCar)
        {
            NameCar = nameCar;
        }
        public string NameCar { get; set; }

        public void Adicionar(ICarComponent iCarComponent)
        {
            Console.WriteLine("Adicionando carro novo");
        }
    }
}