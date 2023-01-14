namespace Cwiczenia_5_Zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj rozmiar tablicy");
            n = System.Int16.Parse(Console.ReadLine());

            int[] tab1 = new int[n];

            int j;
            for (j = 0; j < tab1.Length; j++)
            {
                Console.WriteLine("Podaj Liczbe");
                tab1[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (j = 0; j < tab1.Length; j++)
            {
                //Console.Write(tab1[j] + "\t");
            }
            Console.WriteLine(tab1[tab1.Length-2]);
        }
    }
}