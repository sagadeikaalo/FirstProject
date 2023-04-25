using System;

namespace sagadeevPR15
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics dev = new RoadLogistics("Грузовые перевозки");
            Transport transport2 = dev.Create();
            dev = new AirLogistics("Авиа перевозки");
            Transport transport = dev.Create();
            dev = new railwayLogistics("железнодорожные перевозки");
            Transport transporttrain = dev.Create();
            dev = new seaLogistics("Водные перевозки");
            Transport transportship = dev.Create();
            Console.ReadLine();
        }
    }
    abstract class Logistics
    {
        public string Name { get; set; }
        public Logistics(string n)
        {
            Name = n;
        }

        abstract public Transport Create();
    }
    class RoadLogistics : Logistics
    {
        public RoadLogistics(string n)
        : base(n)
        { }
        public override Transport Create()
        {
            return new TransportTruck();
        }
    }
    class AirLogistics : Logistics
    {
        public AirLogistics(string n)
        : base(n)
        { }
        public override Transport Create()
        {
            return new TransportAir();
        }
    }
    interface Transport
    {
    }
    class TransportTruck : Transport
    {
        public TransportTruck()
        {
            Console.WriteLine("Машина назначена");
        }
    }
    class TransportAir : Transport
    {
        public TransportAir()
        {
            Console.WriteLine("Самолет готов");
        }
    }
    class railwayLogistics : Logistics
    {
        public railwayLogistics(string n)
        : base(n)
        { }
        public override Transport Create()
        {
            return new Transporttrain();
        }
    }
    class Transporttrain : Transport
    {
        public Transporttrain()
        {
            Console.WriteLine("Поезд готов");
        }
    }
    class seaLogistics : Logistics
    {
        public seaLogistics(string n)
        : base(n)
        { }
        public override Transport Create()
        {
            return new Transportship();
        }
    }
    class Transportship : Transport
    {
        public Transportship()
        {
            Console.WriteLine("Корабль готов");
        }
    }
}
