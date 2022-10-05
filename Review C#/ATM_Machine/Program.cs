using System;

namespace MayATM
{
    class Program
    {
        static void Main(string[] args)
        {
           int choice;
           int Password;
           int stk;
           int Password2=0;
           Console.WriteLine("So tien hien tai trong tai khoan cua ban");
           stk=int.Parse(Console.ReadLine());
           Console.WriteLine("mat khau tai khoan");
           Password=int.Parse(Console.ReadLine());
           do{
               Console.WriteLine(" ____________________Menu____________________");
               Console.WriteLine("|1: Dang nhap                                |");
               Console.WriteLine("|2: Kiem tra so tien trong tai khoan         |");
               Console.WriteLine("|3: Nap tien vao tai khoan                   |");
               Console.WriteLine("|4: Rut tien khoi tai khoan                  |");
               Console.WriteLine("|5: Thoat                                    |");
               Console.WriteLine("______________________________________________");
               Console.WriteLine("Nhap lua chon ban muon tu 1-5");
               choice=int.Parse(Console.ReadLine());
               if(0<choice &&choice <6)
               {
                   switch(choice){
                       case 1:
                            if (Password2==Password)
                            {
                                Console.WriteLine("Ban da dang nhap");
                            }
                            else
                            {
                                Console.Write("Nhap Password cua ban: ");
                                Password2=int.Parse(Console.ReadLine());
                                if(Password2.Equals(Password))
                                {
                                    Console.WriteLine("Dang nhap thanh cong.");
                                }
                                else
                                {
                                    Console.WriteLine("Dang nhap that bai.");
                                    continue;
                                }
                            }
                        break;
                        case 2:
                        case 3:
                        case 4:
                            if(Password2!=Password)
                            {
                              Console.WriteLine("Ban chua dang nhap");
                              goto case 1;  
                            }
                            else
                            {
                                if(2<=choice && choice<6)
                                {
                                    switch(choice)
                                    {
                                        case 2:
                                        if(Password2!=Password)
                                        {
                                            Console.WriteLine("Ban chua dang nhap!");
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("So tien hien tai trong tai khoan cua ban la:" +stk);
                                        }
                                        break;
                                        case 3:
                                            naptien:
                                            if (Password2!=Password)
                                            {
                                                Console.WriteLine("Ban chua dang nhap");
                                                continue;
                                            }
                                            else
                                            {
                                               Console.WriteLine(" ________________Menu nap tien_______________");
                                               Console.WriteLine("|1: 100.000                                  |");
                                               Console.WriteLine("|2: 200.000                                  |");
                                               Console.WriteLine("|3: 500.000                                  |");
                                               Console.WriteLine("|4: 1.000.000                                |");
                                               Console.WriteLine("|5: 2.000.000                                |");
                                               Console.WriteLine("|6: Nap tuy y(10x)                           |");
                                               Console.WriteLine("______________________________________________");
                                               Console.WriteLine("Nhap lua chon ban muon tu 1-6");   
                                               int chonnaptien = int.Parse(Console.ReadLine());
                                               switch(chonnaptien) 
                                               {
                                                   case 1:
                                                   
                                                   Console.WriteLine($"So tien trong tai khoan hien tai cua ban la: {stk+100000}");
                                                   Console.WriteLine("So tien ba da nap la 100.000");
                                                   break;
                                                   case 2:
                                                  
                                                   Console.WriteLine($"So tien trong tai khoan hien tai cua ban la: {stk+200000}");
                                                   Console.WriteLine("So tien ba da nap la 200.000");
                                                   break;
                                                   case 3:
                                                   Console.WriteLine($"So tien trong tai khoan hien tai cua ban la: {stk+500000}");
                                                   Console.WriteLine("So tien ba da nap la 500.000");
                                                   break;
                                                   case 4:
                                                   Console.WriteLine($"So tien trong tai khoan hien tai cua ban la: {stk+1000000}");
                                                   Console.WriteLine("So tien ba da nap la 1000.000");
                                                   break;
                                                   case 5:
                                                   Console.WriteLine($"So tien trong tai khoan hien tai cua ban la: {stk+2000000}");
                                                   Console.WriteLine("So tien ba da nap la 2000.000");
                                                   break;
                                                   case 6:
                                                    Console.WriteLine("Nhap so tien ma ban muon nap(10x)");
                                                    long naptuyy =long.Parse(Console.ReadLine());
                                                    if(naptuyy % 10000 == 0)
                                                        {
                                                         Console.WriteLine($"So tien trong tai khoan hien tai cua ban la: {stk+naptuyy}");
                                                         Console.WriteLine($"So tien ban da nap la: {naptuyy}");
                                                        }
                                                        else
                                                        {
                                                         Console.WriteLine("So tien nao ko hop le!, Quy khach vui la nhap lai so tien can nap!");
                                                         goto naptien;
                                                        }
                                                   break;
                                               }
                                                 
                                            }
                                        break;
                                        case 4:
                                            if(Password2!=Password)
                                            {
                                                Console.WriteLine("Ban chua dang nhap!");
                                                continue;
                                            }
                                            else
                                            {
                                               Console.WriteLine(" ________________Menu rut tien_______________");
                                               Console.WriteLine("|1: 10.000                                   |");
                                               Console.WriteLine("|2: 50.000                                   |");
                                               Console.WriteLine("|3: 100.000                                  |");
                                               Console.WriteLine("|4: 200.000                                  |");
                                               Console.WriteLine("|5: 500.000                                  |");
                                               Console.WriteLine("|6: 1.000.000                                 |");
                                               Console.WriteLine("|7: Rut tuy y                                |");
                                               Console.WriteLine("______________________________________________");
                                               Console.WriteLine("Nhap lua chon ban muon tu 1-7"); 
                                               int chonruttien = int.Parse(Console.ReadLine());
                                               switch(chonruttien)
                                               {
                                                   case 1:
                                                    long rut1 = stk -10000;
                                                    if(rut1<0)
                                                    {
                                                       Console.WriteLine("So du trong tai khoan cua ban khong du de thuc hien dich vu! Vui long nap them de tiep tuc su dung dich vu cua chung toi!");
                                                       goto naptien;
                                                    }
                                                    else
                                                    {
                                                       Console.WriteLine("Ban da rut 10000VND");
                                                       Console.WriteLine("So tien con lai trong tai khoan cua ban la: " +rut1);
                                                    }
                                                   break;
                                                    case 2:
                                                    long rut2 = stk -50000;
                                                    if(rut2<0)
                                                    {
                                                       Console.WriteLine("So du trong tai khoan cua ban khong du de thuc hien dich vu! Vui long nap them de tiep tuc su dung dich vu cua chung toi!");
                                                       goto naptien;
                                                    }
                                                    else
                                                    {
                                                       Console.WriteLine("Ban da rut 50000VND");
                                                       Console.WriteLine("So tien con lai trong tai khoan cua ban la: " +rut2);
                                                    }
                                                   break;
                                                    case 3:
                                                    long rut3 = stk -100000;
                                                    if(rut3<0)
                                                    {
                                                       Console.WriteLine("So du trong tai khoan cua ban khong du de thuc hien dich vu! Vui long nap them de tiep tuc su dung dich vu cua chung toi!");
                                                       goto naptien;
                                                    }
                                                    else
                                                    {
                                                       Console.WriteLine("Ban da rut 100000VND");
                                                       Console.WriteLine("So tien con lai trong tai khoan cua ban la: " +rut3);
                                                    }
                                                   break;
                                                    case 4:
                                                    long rut4 = stk -200000;
                                                    if(rut4<0)
                                                    {
                                                       Console.WriteLine("So du trong tai khoan cua ban khong du de thuc hien dich vu! Vui long nap them de tiep tuc su dung dich vu cua chung toi!");
                                                       goto naptien;
                                                    }
                                                    else
                                                    {
                                                       Console.WriteLine("Ban da rut 200000VND");
                                                       Console.WriteLine("So tien con lai trong tai khoan cua ban la: " +rut4);
                                                    }
                                                   break;
                                                    case 5:
                                                    long rut5 = stk -500000;
                                                    if(rut5<0)
                                                    {
                                                       Console.WriteLine("So du trong tai khoan cua ban khong du de thuc hien dich vu! Vui long nap them de tiep tuc su dung dich vu cua chung toi!");
                                                       goto naptien;
                                                    }
                                                    else
                                                    {
                                                       Console.WriteLine("Ban da rut 500000VND");
                                                       Console.WriteLine("So tien con lai trong tai khoan cua ban la: " +rut5);
                                                    }
                                                   break;
                                                    case 6:
                                                    long rut6 = stk -1000000;
                                                    if(rut6<0)
                                                    {
                                                       Console.WriteLine("So du trong tai khoan cua ban khong du de thuc hien dich vu! Vui long nap them de tiep tuc su dung dich vu cua chung toi!");
                                                       goto naptien;
                                                    }
                                                    else
                                                    {
                                                       Console.WriteLine("Ban da rut 1000000VND");
                                                       Console.WriteLine("So tien con lai trong tai khoan cua ban la: " +rut6);
                                                    }
                                                   break;
                                                   case 7:
                                                    Console.WriteLine("Nhap so tien ma ban muon rut(10x)");
                                                    long ruttuyy=long.Parse(Console.ReadLine());
                                                    if(ruttuyy % 10000 == 0)
                                                    {
                                                        long ruttuyy2=stk -ruttuyy;
                                                        if(ruttuyy2<0)
                                                        {
                                                            Console.WriteLine("So du trong tai khoan cua ban khong du de thuc hien dich vu! Vui long nap them de tiep tuc su dung dich vu cua chung toi!");
                                                            goto naptien;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"So tien ban da rut la: {ruttuyy} ");
                                                            Console.WriteLine("So tien con lai  trong tai khoan cua ban la: "+ruttuyy2);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("So tien ban nop ko hop le! Vui long nhap lai so tien ma ban muon nop!");
                                                    }
                                                   break;
                                               }   
                                            }
                                        break;
                                    }break;
                                }
                            }break;
                         case 5:
                         Console.WriteLine("Cam on ban da su dung dich vu cua chung toi!");
                         break;
                   }
               }
           }while(choice !=5);
        }
        /*rut tien nap tien bi sai*/
    }
}
