using System;

namespace ok
{
    class Program
    {
        static void Main(string[] args)
        {
           Boolean Choice =true;
           /*string result; còn 1 cách nữa là dùng toán tử bậc 3(? :)*/
           int Day, Month;
           do{
              
               Console.Write("Nhap vao thang sinh cua ban: ");
               Month = int.Parse(Console.ReadLine());
               if (Month <= 0 || Month >=13)
               {
                   Console.WriteLine("Nhap lai thang!");
                   continue;
               }
               else
               {
                    Day:
                    Console.Write("Nhap vao ngay sinh cua ban: ");
                    Day = Convert.ToInt32(Console.ReadLine());
                    if(Day <=0 || Day >31)
                    {
                    goto Day;
                    } 
                    else
                    {
                         if(Month==2)
                        {
                            if(Day>=30)
                            {
                                goto Day;
                            }
                            else
                            {
                                if (Day <= 18)
                                {
                                    Console.WriteLine("Ban thuoc cung bao binh.");
                                }
                                else
                                {
                                    Console.WriteLine("Ban thuoc cung song ngu.");
                                }

                            }
                        }
                        else if(Month==4||Month==6||Month==9||Month==11)
                        {
                            if (Day > 30)
                            {
                                goto Day;
                            }
                            else
                            {
                             switch (Month)
                                {
                                    case 4:
                                        if (Day <= 19)
                                        {
                                            Console.WriteLine("Ban thuoc cung bach duong.");
                                        }
                                        else
                                            Console.WriteLine("Ban  thuoc cung kim nguu.");
                                        break;
                                    case 6:
                                        if (Day <= 21)
                                        {
                                            Console.WriteLine("Ban thuoc cung song tu.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung cu giai.");
                                        break;
                                    case 9:
                                        if (Day <= 22)
                                        {
                                            Console.WriteLine("Ban thuoc cung xu nu.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung thien binh.");
                                        break;
                                    case 11:
                                        if (Day <= 22)
                                        {
                                            Console.WriteLine("Ban thuoc cung bo cap.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung nhan ma.");
                                        break;
                                }
   
                            }
                        }
                        else
                        {
                            if (Day>31)
                            {
                                goto Day;
                            }
                            else
                            {
                               switch (Month)
                                {
                                    case 1:
                                        if (Day <= 19)
                                        {
                                            Console.WriteLine("Ban thuoc cung ma ket.");
                                        }
                                        else
                                            Console.WriteLine("Ban  thuoc cung bao binh.");
                                        break;
                                    case 3:
                                        if (Day <= 20)
                                        {
                                            Console.WriteLine("Ban thuoc cung song ngu.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung bach duong.");
                                        break;
                                    case 5:
                                        if (Day <= 20)
                                        {
                                            Console.WriteLine("Ban thuoc cung kim nguu.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung song tu.");
                                        break;
                                    case 7:
                                        if (Day <= 22)
                                        {
                                            Console.WriteLine("Ban thuoc cung cu giai.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung su tu.");
                                        break;
                                    case 8:
                                        if (Day <= 22)
                                        {
                                            Console.WriteLine("Ban thuoc cung su tu.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung xu nu.");
                                        break;
                                    case 10:
                                        if (Day <= 22)
                                        {
                                            Console.WriteLine("Ban thuoc cung thien binh.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung bo cap.");
                                        break;
                                    case 12:
                                        if (Day <= 21)
                                        {
                                            Console.WriteLine("Ban thuoc cung nhan ma.");
                                        }
                                        else
                                            Console.WriteLine("Ban thuoc cung ma ket.");
                                        break;
                                }
 
                            }
                        }
                    }
               }
            Console.WriteLine("Ban co muon tiep tuc chuong trinh khong(true/false)");
            Choice = Convert.ToBoolean(Console.ReadLine());
            if(Choice == false)
            {
                Console.WriteLine("Ban da thoat!");
            }
           }while(Choice == true);

         
        }
    }
}
