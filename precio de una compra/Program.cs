using System;

class ProgramaCompra
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto: ");
        string entradaPrecio = Console.ReadLine();
        Console.Write("Ingrese la cantidad: ");
        string entradaCantidad = Console.ReadLine();

        double precio;
        int cantidad;

        bool precioValido = double.TryParse(entradaPrecio, out precio);
        bool cantidadValida = int.TryParse(entradaCantidad, out cantidad);

        if (!precioValido || !cantidadValida)
        {
            Console.WriteLine("Error: debe ingresar valores numéricos válidos.");
            return;
        }

        if (precio <= 0 || cantidad <= 0)
        {
            Console.WriteLine("Error: precio y cantidad deben ser mayores que cero.");
            return;
        }

        double total = precio * cantidad;

        if (total > 25000)
        {
            total = total * 0.90; // aplica 10% de descuento
        }

        Console.WriteLine("Monto final a pagar: ₡{0:F2}", total);
    }
}
