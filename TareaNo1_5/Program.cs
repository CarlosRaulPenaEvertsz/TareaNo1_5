using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNo1_5
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                var empresa = new Empresa() { Nombre = "TECHSHYRA", Direccion = "SALOME URENA #12", RNC = "0018000124", Telefono = "829-773-8324" };
                var cliente = new Cliente() { Codigo = "00014", Nombre = "ROBERTO", Apellido = "DE LEON MARTINEZ", Direccion = "POR AHI" };
                var empleado = new Empleado() { Codigo = "00001", Nombre = "ROSA", Apellido = "FERRERAS", Direccion = "POR AHI", Puesto = "CAJERO" };

                var factura = new Factura(empresa, cliente, empleado);
                factura.Fecha = DateTime.Now;
                Console.WriteLine("++++++++++++ FACTURA ++++++++++++++");
                Console.WriteLine("++++++++++++ " + empresa.Nombre + " ++++++++++++");

                while (true)
                {
                    var producto = new Producto();
                    var detalleFactura = new DetalleFactura();
                    Console.WriteLine("INGRESE CODIGO PRODUCTO");
                    string Campo;
                    Campo=Console.ReadLine();
                    producto.Codigo = Campo; //ESTABA COMO STATEMENT
                    Console.WriteLine("INGRESE NOMBRE PRODUCTO");
                    Campo=Console.ReadLine();
                    producto.Descripcion=Campo; //ESTABA COMO STATEMENT
                    Console.WriteLine("INGRESE PRECIO PRODUCTO");
                    decimal precio;
                    if (decimal.TryParse(Console.ReadLine(), out precio) == false)
                        break;
                    Console.WriteLine("INGRESE CANTIDAD");
                    decimal cantidad;
                    if (decimal.TryParse(Console.ReadLine(), out cantidad) == false)
                        break;
                    producto.Precio = precio;
                    detalleFactura.AddLinea(producto, cantidad);

                    factura.AddLineaFactura(detalleFactura);

                    Console.WriteLine("++++++++++ MENU ++++++++++");
                    Console.WriteLine("[S] CANCELAR");
                    Console.WriteLine("[C] CONTINUAR");
                    Console.WriteLine("[I] IMPRIMIR FACTURA");

                    string op = Console.ReadLine();
                    if (op == "I" || op == "i")
                    {
                        factura.Imprimir();
                        break;
                    }
                    else if (op == "S" || op == "s")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("+++++++++++++++ FACTURA ++++++++++++++++");
                        Console.WriteLine("++++++++++++++++" + empresa.Nombre + "++++++++++++++++");

                    }


                }
                Console.ReadKey();

            }

        }
    }
}
