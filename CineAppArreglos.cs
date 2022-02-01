public class Cine
{
    //variables de cine
    /* nomcine = nombre cine, pgCine = pagina web, fc = facebook */
    public string nomCine, pgCine, fcCine;
    public int telCine;

    static void Main(string[] args)
    {

        Cine cc = new Cine();
        cc.CineRegistro();

    }

    void CineRegistro()
    {

        Cine cc = new Cine();
        //tv es el tamaño del arreglo
        int tv;
        Console.WriteLine("Introduzca la cantidad de cines a registrar: ");
        tv = Convert.ToInt32(Console.ReadLine());
        //Arreglo de objetos
        Cine[] vecCine = new Cine[tv];




        for (int i = 0; i < vecCine.Length; i++)
        {
            Console.WriteLine("Introduzca el nombre del cine: " + i + ": ");
            cc.nomCine = Console.ReadLine();

            Console.WriteLine("Introduzca el telefono del cine: " + i + ": ");
            cc.telCine = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la pagina web del cine: " + i + ": ");
            cc.pgCine = Console.ReadLine();

            Console.WriteLine("Introduzca la direccion de facebook del cine: " + i + ": ");
            cc.fcCine = Console.ReadLine();

            vecCine[i] = cc;



        }
        Console.WriteLine(" " + "\nRegistro de los cines: ");
        for (int j = 0; j < vecCine.Length; j++)
        {


            Console.WriteLine($"El nombre del cine {j} es: {vecCine[j].nomCine}");
            Console.WriteLine($"El telefono del cine {j} es: {vecCine[j].telCine}");
            Console.WriteLine($"La pagina web del cine {j} es: {vecCine[j].pgCine}");
            Console.WriteLine($"El facebook del cine {j} es: {vecCine[j].fcCine}");
            Console.WriteLine("");

            
            //Console.WriteLine(vecCine[j].nomCine + "\t" + vecCine[j].telCine + "\t" + vecCine[j].pgCine + "\t" + vecCine[j].fcCine);
        }
        Console.ReadKey();

    }



}


