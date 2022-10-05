using System.Collections;
using System;

namespace tinh_tien_dien
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, a=default, id, dien=default;
            double tienDien=default;
            string name;
            ArrayList myidList =new ArrayList();
            ArrayList mynameList =new ArrayList();
            ArrayList mydienList = new ArrayList();
            ArrayList tienDienList =new ArrayList();
            int[] tdien=new int[a];
            Console.WriteLine("Nhap so luong nguoi: ");
            a=int.Parse(Console.ReadLine());
            for( i=0; i<a; i++)
            {
                Console.Write($"{i+1}\t\t");
                Console.Write("ID: ");
                id=int.Parse(Console.ReadLine());
                myidList.Add(id);
                Console.Write("Ten: ");
                name=Console.ReadLine();
                mynameList.Add(name);
                Console.Write("Dien da tieu thu: ");
                dien=int.Parse(Console.ReadLine());
                mydienList.Add(dien);
                
            }
            Console.WriteLine("Hoa don thanh toan tien dien");
            Console.WriteLine("len den 199 tuong duong voi 1.2$");
            Console.WriteLine("200 den duoi 400 tuong duong voi 1.5$");
            Console.WriteLine("400 den duoi 600 tuong duong voi 1.8$");
            Console.WriteLine(" lon hon hoac bang 600 tong duong voi 2.0$");
            Console.WriteLine("Neu tien dien vuot qua 400 thi se them 15% phu phi");
            for(i=0; i<a; i++)
            {
                int soDienTieuThu =(int)mydienList[i];
                {
                    if(soDienTieuThu < 100)
                    {
                       
                        tienDien= 120;
                    }
                    else if(100<= soDienTieuThu && soDienTieuThu<200)
                    {
                       
                        tienDien= Math.Round(soDienTieuThu*1.2, 2);
                    }
                    else if(200<= soDienTieuThu && soDienTieuThu<400)
                    {
                       
                       tienDien=Math.Round(soDienTieuThu*1.5, 2);
                    }
                    else if(400<= soDienTieuThu && soDienTieuThu<600)
                    {
                        
                     double tien1=soDienTieuThu*1.8*0.15;
                     tienDien=Math.Round((tien1+soDienTieuThu*1.8), 2);  
                    }
                    else if(soDienTieuThu>=600)
                    {
                       
                     double tien2= soDienTieuThu*2*0.15;
                     tienDien = Math.Round((tien2+soDienTieuThu*2), 2);   
                    }
                }
                tienDienList.Add(tienDien);
            }
            for(i=0;i<a; i++)
            {
                Console.WriteLine($"{i+1}");
                Console.WriteLine("ID cua nguoi dung la: " +myidList[i]);
                Console.WriteLine("Ten cua nguoi dung: "+mynameList[i]);
                Console.WriteLine("So dien ma nguoi dung so da tieu thu la: "+mydienList[i]);
                Console.WriteLine("So tien dien ma nguoi do phai thanh toan la: "+tienDienList[i]+"$");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
