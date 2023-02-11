internal class Program
{

    public struct Tienda
    {
        public int idProducto;
        public string nombreProducto;
        public int precio;

        public Tienda(int idProducto, string nombreProducto, int precio){
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
        }

    }

    public struct Dueño
    {
        public string nombreDueño;

        public Dueño(string nombreDueño){
            this.nombreDueño = nombreDueño;

        }
    }

    public struct Mascota
    {
        public string nombreMas;
        public string raza;

        public Dueño dueño;

        public Mascota(string nombreMas, string raza, string nombreDueño){
            this.nombreMas = nombreDueño;
            this.raza = raza;

            dueño = new Dueño(nombreDueño);
        }
    }

    enum neumaticos {verano, invierno, asimetrico, radial};
    private static void Main(string[] args)
    {
        /*
        1. Crear una estructura para guardar los
        productos de una tienda.
        */

        Tienda producto = new Tienda(20200447, "Palito de coco", 2000);
        
        /*
        3. Crear estructuras enlazadas para guardar
        la información de una mascota y su
        dueño.
        */

        Mascota mascota = new Mascota("Sara", "Gato", "Glennys");

       /* 4. Crear una enumeración para los
        diferentes tipos de neumáticos.*/

        neumaticos neu = neumaticos.asimetrico;

        System.Console.WriteLine($"Los neumaticos que me gustan son {neu}");







    }
}