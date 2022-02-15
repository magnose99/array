using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sort
           int[] sayiDizisi = {23,12,4,86,45,3,6,8};
           Console.WriteLine("*** Sırasız Dizi ***");
           foreach(var sayi in sayiDizisi)
           Console.WriteLine(sayi);

           Console.WriteLine("*** Sıralı Dizi ***");
           Array.Sort(sayiDizisi);
           foreach (var sayi in sayiDizisi)
           Console.WriteLine(sayi);

           //Clear
           Console.WriteLine("*** Array Clear ***");
           // sayiDizisi elemanlarını kullanarak 2.indez ten itibaren 2 tane elemanı 0'lar.
           Array.Clear(sayiDizisi,2,2);
           foreach(var sayi in sayiDizisi)
           Console.WriteLine(sayi);

           //Reverse
           Console.WriteLine("*** Array Reverse ***");
           Array.Reverse(sayiDizisi);
           foreach(var sayi in sayiDizisi)
           Console.WriteLine(sayi);

           //IndexOf (sayının indexini bulma)
           Console.WriteLine("*** Array İndexOf ***");
           Console.WriteLine(Array.IndexOf(sayiDizisi,23));

           //Resize (dizinin boyutunu arttırma)
           Console.WriteLine("*** Array Resize ***");
           Array.Resize<int>(ref sayiDizisi,9);
           sayiDizisi[8] = 1;
           foreach(var sayi in sayiDizisi)
           Console.WriteLine(sayi);

        }
    }
}
