namespace TusindeFryd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlomsterSortRepository blomsterSortRepository = new BlomsterSortRepository();

            BlomsterSort blomsterSort = new BlomsterSort("Tullipan");
            BlomsterSort blomsterSort1 = new BlomsterSort("Rose", 55);
            BlomsterSort blomsterSort2 = new BlomsterSort("Simon", 50, 27);
            BlomsterSort blomsterSort3 = new BlomsterSort("Rødbede", 20, 15, 0.5);

            blomsterSortRepository.AddToList(blomsterSort);
            blomsterSortRepository.AddToList(blomsterSort1);
            blomsterSortRepository.AddToList(blomsterSort2);
            blomsterSortRepository.AddToList(blomsterSort3);

            //Console.WriteLine(blomsterSort.ToString());
            //Console.WriteLine(blomsterSort1.ToString());
            //Console.WriteLine(blomsterSort2.ToString());
            //Console.WriteLine(blomsterSort3.ToString());

            foreach (var item in blomsterSortRepository.blomsterSorts)
            {
                Console.WriteLine(item.ToString());
             }

            Console.ReadLine();
        }
    }
}
