using Composite.APP.Composite;
using Composite.APP.Interface;
using Composite.APP.Service;
using System;

namespace Composite.APP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OLÁÁÁÁÁ, Bora listar o nome do veiculo");

            ICarComponent service0 = new CarService("BMW - 2021");
            ICarComponent service1 = new CarService("BMW - 2020");
            ICarComponent service2 = new CarService("BMW - 2019");

            ICarComponent component = new CarComposite("VOLVO - 1960");
            ICarComponent component1 = new CarComposite("VOLVO - 1970");
            ICarComponent component2 = new CarComposite("VOLVO - 1980");

            component.Adicionar(component1);
            component.Adicionar(component2);

            component1.Adicionar(service0);
            component1.Adicionar(service1);

            component2.Adicionar(service2);
            component2.Adicionar(new CarService("ULTIMO CARRO INSERIDO - UNO - 2022"));

            Console.WriteLine(component);
            Console.ReadKey();
        }
    }
}
