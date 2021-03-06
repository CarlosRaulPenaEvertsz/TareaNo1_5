﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNo1_5
{
    public class Factura
    {
        private Empresa empresa;
        private Cliente cliente;
        private Empleado empleado;
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Itbis { get; set; }
        public decimal Total { get; set; }
        public List<DetalleFactura> lineaFactura { get; set; }

        public Factura(Empresa empresa, Cliente cliente, Empleado empleado)
        {
            this.empresa = empresa;
            this.cliente = cliente;
            this.empleado = empleado;
            lineaFactura = new List<DetalleFactura>();
        }

        public void AddLineaFactura(DetalleFactura lf)
        {
            lineaFactura.Add(lf);
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("Imprimiendo factura......");
            Console.WriteLine();
            Console.WriteLine(empresa.Nombre);
            Console.WriteLine(empresa.Direccion + " Tel‚fono: " + empresa.Telefono);
            Console.WriteLine(empresa.RNC);
            Console.WriteLine("Fecha: " + this.Fecha.ToString("dd/MM/yyyy"));
            Console.WriteLine("++++++++++++");
            Console.WriteLine("Cliente: " + cliente.Codigo + " " + cliente.Nombre);
            Console.WriteLine("++++++++++++");
            Console.WriteLine("Cajero(a): " + empleado.Codigo + " " + empleado.Nombre);
            Console.WriteLine("++++++++++++");
            Console.WriteLine("CODIGO\tDESCRIPCION\tCANTIDAD\tPRECIO\tTOTAL");
            foreach (var item in lineaFactura)
            {
                Console.WriteLine(item.Producto.Codigo + "\t" + item.Producto.Descripcion + "\t" + item.Cantidad + "\t\t" + item.Producto.Precio.ToString("C") + "\t" + item.Total.ToString("C"));
                this.Total += item.Total;
            }
            Console.WriteLine("TOTAL: " + this.Total.ToString("c"));
        }

    }
}
