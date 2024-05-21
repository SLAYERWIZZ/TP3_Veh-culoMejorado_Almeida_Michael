using System;

namespace vehiculos
{
    class Program
    {
        class Vehiculo
        {
            private string _Marca;
            public string Marca
            {
                get { return _Marca; }
                set { _Marca = value; }
            }
            private string _Modelo;
            public string Modelo
            {
                get { return _Modelo; }
                set { _Modelo = value; }
            }
            private int _Año;
            public int Año
            {
                get { return _Año; }
                set { _Año = value; }
            }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año}");
            }
        }
        class bicicleta : Vehiculo
        {
            private int _Numeromarchas;
            public int Numeromarchas
            {
                get { return _Numeromarchas; }
                set { _Numeromarchas = value; }
            }
            public bicicleta(string marca, string modelo, int año, int numeromarcha) : base(marca, modelo, año)
            {
                numeromarcha = numeromarcha;
            }
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Bicicleta \nmarchas: {Numeromarchas}");
            }
        }
        class Avion : Vehiculo
        {
            private string _TipoMotor;
            public string TipoMotor
            {
                get { return _TipoMotor; }
                set { _TipoMotor = value; }
            }

            public Avion(string marca, string modelo, int año, string tipoMotor) : base(marca, modelo, año)
            {
                TipoMotor = tipoMotor;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Avión \nTipo de motor: {TipoMotor}");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("--------VEHICULOS--------");
            Vehiculo vehi = new Vehiculo("Toyota", "Aveo", 2012);
            Vehiculo vehi2 = new Vehiculo("Chevrolet", "supra", 2022);
            vehi.MostrarInformacion();
            Console.WriteLine("-----------------");
            vehi2.MostrarInformacion();
            bicicleta bic = new bicicleta("bmx", "Plus", 2025, 1);
            Console.WriteLine("-----------------");
            bic.MostrarInformacion();
            Console.WriteLine("-----------------");
            Console.WriteLine("--------AVION---------");
            Avion avi = new Avion("Airbus SAS", "united", 1980, "Rolls-Royce Trent 700");
            avi.MostrarInformacion();
        }
    }
}