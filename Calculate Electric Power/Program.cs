using System;

namespace tinhtiendienphuongthuc
{
    class Program
    {
        struct KhachHang
        {
            public int id;
            public string ten;
            public int soDien;
        }
        static void NhapThongTin(KhachHang[] arr)
        {
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine($"Nhap ten khach hang{i+1}:");
                arr[i].ten=Console.ReadLine();
                Console.WriteLine($"Moi nhap id khach hang{i+1}: ");
                arr[i].id=int.Parse(Console.ReadLine());
               
            }
        }
        static void TinhTienDien(KhachHang[] arr)
        {
            int id;
            int soDienTieuThu;
            double tienDien=default;
            Console.WriteLine("ID cua khach");
            id =int.Parse(Console.ReadLine());
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i].id==id)
                {
                    Console.WriteLine("Nhap luong dien tieu thu thang nay(Rs)");
                    soDienTieuThu=int.Parse(Console.ReadLine());
                    arr[i].soDien+=soDienTieuThu;
                   
                    
                        
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
                    Console.WriteLine($"ID Khach Hang: {arr[i].id}");
                    Console.WriteLine($"Luong dien da tieu thu la {soDienTieuThu}");
                    Console.WriteLine($"Tong luong dien da su dung{arr[i].soDien}");
                    Console.WriteLine($"Tien dien ma ban phai tra la {tienDien} Rs");
                    break;
                }
            }
        }
        static void luaChon(KhachHang[] arr)
        {
            bool isExit=false;
            int choice;
            do
            {
                Console.WriteLine("1.Nhap lai thong tin khach hang");
                Console.WriteLine("2. Nhap so tien dung trong thang nay vaf tinhs tien dien thang");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Moi nhap lua chon");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    NhapThongTin(arr);
                   break;
                   case 2:
                   TinhTienDien(arr);
                   break;
                   case 0:
                    Console.WriteLine("Ban da thoat chuong trinh");

                    isExit=true;
                   break;
                }
            }while(isExit==false);
        }
        static void Main(string[] args)
        {
            int soluong;
            Console.WriteLine("Nhap so luong khach hang");
            soluong =int.Parse(Console.ReadLine());
            KhachHang[] arr =new KhachHang[soluong];
            NhapThongTin(arr);
            luaChon(arr);
        }
    }
}
