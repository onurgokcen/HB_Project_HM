using HalkBankCore;

namespace HalkBankListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new HalkBankList();
            list.Ekle("Salih");
            list.Ekle("Engin");
            list.Ekle("Mustafa");
            list.Ekle("Ahmet");
            //list.Ekle("Erol");
            list.Sil(3);

            list[2] = "Mehmet";
            foreach (var eleman in list)
            {
                Console.WriteLine(eleman);
            }
            
            Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);
            list.KosulluSil(list => list.Equals(1));
            //Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);

            //for (int i = 0; i < list.ElemanSayisi; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            foreach (var eleman in list)
            {
                Console.WriteLine(eleman);
            }

            //list.Temizle();

            Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);

            Console.ReadLine();
        }
    }
}