using Composite.APP.Interface;
using System;
using System.Collections.Generic;

namespace Composite.APP.Composite
{
    public class CarComposite : ICarComponent
    {
        public CarComposite(string nameCar)
        {
            NameCar = nameCar;
            this.carro = new List<string>();
        }

        public string NameCar { get; set; }
        List<string> carro = new List<string>();

        public void Adicionar(ICarComponent iCarComponent)
        {
            carro.Add(iCarComponent.NameCar);
            iCarComponent.NameCar = NameCar + "Adicionando no composite";
        }
    }
}
