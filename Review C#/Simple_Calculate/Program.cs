

using System;

namespace maytinhdongian
{
    class Program
    {
        static void Main(string[] args)
        {
          /*string option ="yes";
          while(option == "yes")
          {*/
          
          int c;
          int a, b;
          do{
             Console.WriteLine("----------Menu----------");
             Console.WriteLine("|1. Phep cong:---------|");
             Console.WriteLine("|2. Phep tru:----------|");
             Console.WriteLine("|3. Phep nhan:---------|");
             Console.WriteLine("|4. Phep chia:---------|");
             Console.WriteLine("|5. Phep chia(lay du):-|");
             Console.WriteLine("|6. Phep Luy Thua:-----|");
             Console.WriteLine("|7. Thoat chuong trinh!|");
             Console.WriteLine("------------------------");
             Console.WriteLine("Nhap phep tinh ban muon tu 1-6: ");
             c=int.Parse(Console.ReadLine());
              
             if(0 <c && c<7)
             {
               Console.WriteLine("Nhap so a: ");
               a = int.Parse(Console.ReadLine());
               Console.WriteLine("Nhap so b: ");
               b = int.Parse(Console.ReadLine());
                switch(c)
               {
               
                 case 1:
                  float tong =a +b;
                  Console.WriteLine($"Tong cua {a} va {b} la: " + tong);
                 break;
            
                 case 2:
                  float hieu =a - b;
                  Console.WriteLine($"Hieu cua {a} va {b} la: " + hieu);
                  break;
            
                 case 3:
            
                 float tich =a * b;
                 Console.WriteLine($"Tich cua {a} va {b} la: " + tich);
                 break;
            
                 case 4:
                 if(b!=0)
                  {
                   float thuong = (float)a/b;
                   Console.WriteLine($"Thuong cua {a} va {b} la: " +thuong );
                  }  
                 else
                 Console.WriteLine("Khong Xac Dinh! Nhap lai b.");
                 break;            
            
                 case 5:
                 if(b!=0)
                 {
                  float chiaLayDu = a % b;
                  Console.WriteLine($"So du cua {a} va {b} la: "  + chiaLayDu );
                 }
                 else
                 Console.WriteLine("Khong xac dinh! Nhap lai b!");
                 break;
                 case 6:
                 double mu = Math.Pow(a,b);
                 Console.WriteLine($"Luy thua co so {a} mu {b} la: " + mu);
                 break;
               }
             }
             }
             while(c!=7); 
             
               Console.WriteLine("Ban da thoat");      
               Console.ReadLine();
             
        }     
    }   
}  