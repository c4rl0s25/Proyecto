﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Contextos;
using Proyecto.Modelos;
namespace ConsolaDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            VentasAutos VentasAutos = new VentasAutos();

            Concesionario concesionario = new Concesionario();
            concesionario.Nombre = "Maquinarias";
            concesionario.Distrito = "San Isidro";
            concesionario.DiaDeCreacion = DateTime.Now;

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Marca = "KIA";
            vehiculo.Modelo = "Picanto";
            vehiculo.Color = "Blanco";
            vehiculo.Precio = 9600;

            concesionario.Vehiculos.Add(vehiculo);

            Cliente cliente = new Cliente();
            cliente.Nombre = "Carlos";
            cliente.Dni = 46734678;
            cliente.Direccion = "Av San martin 123";

            vehiculo.Clientes.Add(cliente);

            VentasAutos.Concesionarios.Add(concesionario);
            VentasAutos.SaveChanges();
        }
    }
}
