using EXERCISE_CAT;

internal class Program
{
    private static void Main(string[] args)
    {

        Gato g = new Gato();
        Persa gatito1 = new Persa();
        gatito1.tamaño="G";
        gatito1.nombre="coca de lata";
        gatito1.color="negro";
        gatito1.Peso=2.3m;

        gatito1.comer();
        gatito1.correr();
        gatito1.jugar();

        Egipcio grangato = new Egipcio();
        grangato.nombre="mistofeles";
        grangato.color="Negro";
        grangato.tamaño="G";
        grangato.Peso = 15.36M;

        
    }
}