using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculosDB.Core.Clases
{
    internal class Vehiculos
    {
        private int idVehiculo;
        private string placa;
        private string modelos; 
        private int anio;
        private string color;

        private Marcas marcas;
        private Propietario propietario;
        private TiposCarro tipoCarro;

        public Vehiculos()
        {
            marcas = new Marcas();
            propietario = new Propietario();
            tipoCarro = new TiposCarro();
        }



        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Modelos { get => modelos; set => modelos = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Color { get => color; set => color = value; }
        public Marcas Marcas { get => marcas; set => marcas = value; }
         public Propietario Propietario { get => propietario; set => propietario = value; }
        public TiposCarro TipoCarro { get => tipoCarro; set => tipoCarro = value; }


        // atributos de clases anidadas
        public int idMarca { get => marcas.IdMarca ; set=>marcas.IdMarca = value;}
        public string nombreMarca { get => marcas.NombreMarca; set => marcas.NombreMarca = value; }

        public int idPropietario { get => propietario.IdPropietario; set => propietario.IdPropietario = value; }
        public string Dui { get => propietario.Dui; set => propietario.Dui = value; }

        public int idTipoCarro { get => tipoCarro.IdTipoCarro; set => tipoCarro.IdTipoCarro = value; }
        public string nombreTipoCarro { get => tipoCarro.NombreTipo; set => tipoCarro.NombreTipo = value; }

    }
}
