namespace EvTapshirigi10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());

            }
             foreach (var item in arr)
            {
               if (item < min)
                    min = item;
            }
            Console.WriteLine(min);
        }
    }
}
