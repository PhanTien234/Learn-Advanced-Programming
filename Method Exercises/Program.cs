using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_phuong_thuc
{
    class Program
    {
        Program p=new Program();
        static void Main(string[] args)
        {
            
            int n,j=0, k=0;
            do{
              Console.WriteLine("Vui long nhap n trong pham vi nay (0<n<100)");
              Console.WriteLine("Nhap n");
              n=int.Parse(Console.ReadLine());
          }while(n<1|| n>99);
          int[] arr=new int[n];
          int[] arr1 =new int[n];
          int[] arr2 = new int[n];

          p.NhapMang(arr,n);
          for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr1[j] = arr[i];
                    j++;
                }
                else
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }

          
           XuatHienMang(arr);
           XuatPhanTuChan(arr1,j);
           XuatPhanTuLe(arr2, k);
          
           XuatPhanTuChanNguoc(arr1, n);
           XuatPhanTuLeNguoc(arr2, n);
           XuatPhanTuAm(arr, n);
           XuatPhanTuDuong(arr, n);
           Console.WriteLine("Phan tu lon nhat la: " + TimPhanTuLonNhat(arr,n));
           Console.WriteLine("Phan tu nho nhat la: " + TimPhanTuNhoNhat(arr,n));
           Console.WriteLine("So phan tu le trong mang la: " + DemPhanTuLe(arr,n));
           Console.WriteLine("So phan tu am trong mang la: " + DemPhanTuAm(arr,n));
           Console.WriteLine("Tong cac phan tu co trong mang la: " + TinhTongCacPhanTu(arr,n));
           Console.WriteLine("Tong cac phan tu o vi tri chan la: " + TinhTongCacPhanTuOViTriChan(arr,n));
           p.CoPhaiSoNguyenTo(arr, n);
           /*InCacSoNguyenTo(arr,n);
           Console.WriteLine("So luong so nguyen to trong mang: " + DemCacSoNguyenTo(arr, n));*/
            CoPhaiSoChinhPhuong(arr);

        }
       
        public void NhapMang(int[] arr, int n)
        {
           for(int i=0; i<n; i++)
           {
                Console.Write($"Phan tu {i+1} la: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
           }
            
        }
        static void XuatHienMang(int[] arr)
        {
            Console.WriteLine("Cac so nguyen trong mang la: ");
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
        }
        static void XuatPhanTuChan(int[] arr1, int j)
        {
            Console.WriteLine("Cac phan tu chan lan luot la: ");
            for (int i = 0; i < j; i++)
            {
                Console.Write(" " +arr1[i]);
            }

        }
        static void XuatPhanTuLe(int[] arr2, int k)
        {
             Console.WriteLine("\nCac phan tu le lan luot la: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(" "+ arr2[i]);
            }
            Console.WriteLine();    
        }
        static void XuatPhanTuChanNguoc(int[] arr1, int n )
        {
        Console.WriteLine("Cac phan tu chan nguoc lan luot la: ");
           for(int i=n-1; i>=0; i--)
          {
              Console.Write(" "+ arr1[i]);
          }
          Console.WriteLine();
            

        }
        static void XuatPhanTuLeNguoc(int[] arr2, int n)
        {
            Console.WriteLine("Cac phan tu le nguoc lai la: ");
            for(int i=n-1; i>=0; i--)
          {
              Console.Write(" "+ arr2[i]);
          }
          Console.WriteLine();
        }
        static void XuatPhanTuAm(int[] arr, int n)
        {
            string trungGian = "";

            for (int i = 0; i < n; i++)
            {

                if (arr[i] < 0) trungGian += arr[i] +"  " ;
                
            }
            if (trungGian != "")

                    {
                        trungGian = trungGian.Substring(0, trungGian.Length - 1);
                        Console.WriteLine("Cac phan tu am theo thu tu nhap: " + trungGian);
                    }


               
        }
        static void XuatPhanTuDuong(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = n - 1; i >= 0; i--)

            {
                 if (arr[i] > 0) trungGian += arr[i] + "  ";
            }
            if (trungGian != "")
            {
                 trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac phan tu duong nguoc thu tu nhap: " + trungGian);
            }

        }
        static int TimPhanTuLonNhat(int[] arr, int n)
        {
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
            if (max < arr[i]) 
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int TimPhanTuNhoNhat(int[] arr, int n)
        {
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
            if (min > arr[i]) 
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static int DemPhanTuLe(int[] arr, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 1) 
                {
                    dem++;
                }
            }

            return dem;
        }
        static int DemPhanTuAm(int[] arr, int n)
        {
            
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] <0) 
                {
                    dem++;
                }
            }
            return dem;
        }
        static long TinhTongCacPhanTu(int[] arr, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            return sum;
            
        }
        static long TinhTongCacPhanTuOViTriChan(int[] arr, int n)
        {
             long sum = 0;
            for (int i = 0; i < n; i+=2)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static bool CoPhaiSoNguyenTo( int n)
        {

            if (n < 2) 
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                   return false; 
                }
            }
            return true;

        }
        /*static void InCacSoNguyenTo(int[] arr, int n)
        {
            string trungGian = "";

            for (int i = 0; i < n; i++)

            {
                if (CoPhaiSoNguyenTo(arr[i]))
                {
                    trungGian += arr[i] + "  ";
                }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac so nguyen to trong mang: " + trungGian);
            }

        }*/
        /*static int DemCacSoNguyenTo(int[] arr, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (CoPhaiSoNguyenTo(arr[i]))
                {
                dem++;
                }
            }
            return dem;
        }*/
        /*static long TongCacSoNguyenTo(int[] arr, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (CoPhaiSoNguyenTo(arr[i]))
                {
                    sum += arr[i];
                }
            }
            return sum;
        }*/
        public Boolean CoPhaiSoChinhPhuong(int arr)
        {
            Boolean ketQua = false;
            double x = Math.Sqrt(arr);
            if ((int)x * x == arr)
            { 
                ketQua = true; 
            }
            return ketQua;
            
        }



    }
}