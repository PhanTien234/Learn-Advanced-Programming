using System;

namespace nhap
{
    class Program
    {
       public static string Revesrve(string index)
        {
            char[] arr = index.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string chuoi = "Greenwich's Club of Developers";
            string daochuoi = Revesrve(chuoi);
            int size = chuoi.Length;
            Console.WriteLine("So ki tu: " +size);
            string tolower = chuoi.ToLower();
            Console.WriteLine("In thuong: " +tolower);
            string toupper = chuoi.ToUpper();
            Console.WriteLine("In hoa: "+toupper);
            foreach (var s in chuoi)
            {
                Console.Write(" " + s) ;
            }
            Console.WriteLine("\nDao nguoc chuoi: " +daochuoi);
            string catchuoi = chuoi.Substring(12, 4);
            Console.WriteLine("chuoi moi:" + catchuoi);

           int dem = 0;
           int lan = -1;
           int idx = -1;
           char solan = 'e';
           while (dem != -1)
           {
               dem =chuoi.IndexOf(solan, idx + 1);
               lan += 1;
               idx = dem;
           }
           Console.Write("e da xuat hien:" + lan + " lan.");  

           Console.ReadLine();
        }
    }
}
