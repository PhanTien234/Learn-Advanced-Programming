using System;

namespace okconde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so mang ma ban muon tao:");
            int a= int.Parse(Console.ReadLine());
           string[] mang= new string[a] ;
           for(int i=0; i< mang.Length; i++)
           {
               mang[i] =Console.ReadLine();
           }
            for(int i=0; i< mang.Length; i++)
           {
              Console.WriteLine($"Danh sach cac mang: {mang[i]}" );
           }
           Array.Sort(mang);
            for(int i=0; i< mang.Length; i++)
           {
              Console.WriteLine($"Danh sach cac mang sau khi sap xep: {mang[i]}" );
           }
           
           foreach (var item in mang)
           {
               Console.WriteLine($"danh sach cac phan tu trong mang: {item}" );
           }
           Console.ReadLine();
        }
    }
}
