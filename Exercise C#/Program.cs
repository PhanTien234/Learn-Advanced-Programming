using System;

namespace nhap5
{
    class Program
    {
       public void setArray(ref int n, ref int[] arr)
        {
            do
            {
                Console.Write("Nhap n (0<n<100): ");
                n = int.Parse(Console.ReadLine());
            } while (n >= 100 || n <= 0);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine().ToString());
            }
        }
//Ham in tat ca cac phan tu trong mang
        public void print(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = 0; i < n; i++)
            {
                trungGian += arr[i] + "  ";
            }
            Console.WriteLine("Day so vua nhap: " + trungGian.Substring(0, trungGian.Length - 1));
        }
//Ham in tat ca cac phan tu chan trong mang theo thu tu nhap
        public void printEvenNumber(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = 0; i < n; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    trungGian += arr[i] + "  ";
                }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac phan tu chan trong mang theo thu tu nhap: " + trungGian);
            }
        }
//Ham in tat ca cac phan tu le trong mang nguoc thu tu nhap
        public void printOddNumber(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 1)
                {
                    trungGian += arr[i] + "  ";
                }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac phan tu le trong mang nguoc thu tu nhap: " + trungGian);
            }
        }
//Ham in tat ca cac phan tu o vi tri chan nguoc thu tu nhap
        public void printEvenIndex(int[] arr, int n)
        {
            string trungGian = "";
            if (n % 2 == 0)
            {
               n--; 
            } 
            for (int i = n - 1; i >= 0; i-=2)
            {
            trungGian += arr[i] + "  ";
            }
            Console.WriteLine("Cac phan tu o vi tri chan nguoc thu tu nhap: " + trungGian.Substring(0, trungGian.Length - 1));
        }
//Ham in tat ca cac phan tu o vi tri le theo thu tu nhap
        public void printOddIndex(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = 1; i < n; i += 2)
            {
               trungGian += arr[i] + "  "; 
            }
            Console.WriteLine("Cac phan tu o vi tri le theo thu tu nhap: " + trungGian.Substring(0, trungGian.Length - 1));
        }
//Ham in tat ca cac phan tu am theo thu tu nhap
        public void printNegativeNumber(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    trungGian += arr[i] + "  ";
                }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac phan tu am theo thu tu nhap: " + trungGian);
            }
        }
//Ham in tat ca cac phan tu duong nguoc thu tu nhap
        public void printPositiveNumbers(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] > 0) 
                {
                    trungGian += arr[i] + "  ";
                }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac phan tu duong nguoc thu tu nhap: " + trungGian);
            }
        }
//Ham tim phan tu lon nhat
        public int getMax(int[] arr, int n)
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
//Ham tim phan tu be nhat
        public int getMin(int[] arr, int n)
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
//Ham dem so phan tu le trong mang
        public int getCountOddNumber(int[] arr, int n)
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
//Ham dem so phan tu am trong mang
        public int getCountNegativeNumber(int[] arr, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                { 
                    dem++;
                }
            }
            return dem;
        }
//Ham tinh tong cac phan tu trong mang
        public long getTotal(int[] arr, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            sum += arr[i];
            return sum;
        }
//Ham tinh tong cac phan tu o vi tri chan trong mang
        public long getTotalEvenIndex(int[] arr, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i += 2)
            {
            sum += arr[i];
            }
            return sum;
        }
//Ham xac dinh mot so co phai so nguyen to hay khong
        public Boolean isPrimeNumber(int n)
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
//Ham in cac so nguyen to trong mang
        public void printPrimeNumber(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = 0; i < n; i++)
            {
                if (isPrimeNumber(arr[i]))
                    {
                    trungGian += arr[i] + "  ";
                    }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac so nguyen to trong mang: " + trungGian);
            }
        }
//Ham dem so luong cac so nguyen to trong mang
        public int getCountPrimeNumber(int[] arr, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (isPrimeNumber(arr[i]))
                {
                    dem++;
                }
            }
            return dem;
        }
//Ham tinh tong cac so nguyen to trong mang
        public long getTotalPrimeNumber(int[] arr, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (isPrimeNumber(arr[i]))
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
//Ham kiem tra mot so co phai so chinh phuong hay khong
        public Boolean isSquareNumber(int arr)
        {
            Boolean ketQua = false;
            double x = Math.Sqrt(arr);
            if ((int)x * x == arr) { ketQua = true; }
            return ketQua;
        }
//Ham in cac so chinh phuong trong mang
        public void printSquareNumber(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = 0; i < n; i++)
            {
                if (isSquareNumber(arr[i]))
                {
                    trungGian += arr[i] + "  ";
                }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac so chinh phuong trong mang: " + trungGian);
            }
        }
//Ham tinh tong cac so chinh phuong trong mang
        public long getTotalSquareNumber(int[] arr, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (isSquareNumber(arr[i]))
                {
                sum += arr[i];  
                }
            }
            return sum;
        }
//Ham kt 1 so phai so hoan thien khong
        public Boolean isPerfectNumber(int n)
        {
            if (n < 0) 
            {
                return false;
            }
            int sum = 1;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (sum > n) 
                    {
                        return false;
                    }
                }
            }
            return sum == n;
        }
//Ham in cac so hoan thien trong mang
        public void printPerfectNumber(int[] arr, int n)
        {
            string trungGian = "";
            for (int i = 0; i < n; i++)
            {
                if (isPerfectNumber(arr[i]))
                {
                    trungGian += arr[i] + "  ";
                }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac so hoan thien trong mang: " + trungGian);
            }
        }
//Ham tim vi tri xuat hien dau tien cua phan tu x trong mang
        public int getFirstPosition(int[] arr, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
//Ham dem so lan xuat hien cua phan tu x trong mang
        public int getCountEqual(int[] arr, int n, int x)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    dem++;
                }
            }
            return dem;
        }
//Ham in ra tat ca vi tri cua x trong mang
        public void printIndexByValue(int[] arr, int n, int x)
        {
            string trungGian = "";
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    trungGian += arr[i] + "  ";
                }
            }
            if (trungGian != "")
            {
                trungGian = trungGian.Substring(0, trungGian.Length - 1);
                Console.WriteLine("Cac vi tri xuat hien cua {0} trong mang: {1} ", x, trungGian);
            }
        }
//Ham them 1 phan tu vao cuoi mang
        public void insertLast(ref int[] arr, ref int n, int x)
        {
            arr[n] = x;
            n++;
        }
//Ham them 1 phan tu vao dau mang
        public void insertFirst(ref int[] arr, ref int n, int x)
        {
            for (int i = n; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = x;
            n++;
        }
//Ham chen 1 phan tu vao dung vi tri
        public void insertAt(ref int[] arr, ref int n, int x, int k)
        {
            if (k == 0)
            {
                insertFirst(ref arr, ref n, x);
            }
            else
            {
                if (k == n)
                {
                    insertLast(ref arr, ref n, x);
                }
                else
                {
                    for (int i = n; i > k; i--)
                    {
                        arr[i] = arr[i - 1];
                    }
                    arr[k] = x;
                    n++;
                }
            }
        }
//Ham xoa 1 phan tu cuoi mang
        public void removeLast(int[] arr, ref int n)
        {
            if (n == 0)
            {
                return;
            }
            n--;
        }
//Ham xoa 1 phan tu dau cua mang
        public void removeFirst(ref int[] arr, ref int n)
        {
            if (n == 0) return;
            for (int i = 0; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            n--;
        }
//Ham xoa mot phan tu tai vi tri k
        public void removeAt(ref int[] arr, ref int n, int k)
        {
            if (k < 0 || k >= n)
            { 
                return;
            }
            if (k == 0)
            {
                removeFirst(ref arr, ref n);
            }
            else
            {
                if (k == n - 1) 
                { 
                    removeLast(arr, ref n); 
                }
                else
                {
                    for (int i = k; i < n - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    n--;
                }
            }
        }
//Ham xoa x dua vao vi tri xuat hien dau tien cua x
        public void removeFirst(ref int[] arr, ref int n, int x)
        {
            int kiemTra = getFirstPosition(arr, n, x);
            removeAt(ref arr, ref n, kiemTra);
        }
//Ham xoa tat ca x trong mang
        public void removeAll(ref int[] arr, ref int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                removeFirst(ref arr, ref n, x);
            }
        }
//Ham hoan vi hai so a,b
        public void swap(ref int arr, ref int b)
        {
            int tmp = arr;
            arr = b;
            b = tmp;
        }

//Ham sap mang tang dan
        public void ascSort(ref int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j]) 
                    {
                        swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
//Ham sap mang giam dan
        public void descSort(ref int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j]) 
                    {
                        swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int n = 0; int[] arr = new int[100];
            p.setArray(ref n, ref arr);
            p.print(arr, n);
            p.printEvenNumber(arr, n);
            p.printOddNumber(arr, n);
            p.printEvenIndex(arr, n);
            p.printOddIndex(arr, n);
            p.printNegativeNumber(arr, n);
            p.printPositiveNumbers(arr, n);
            Console.WriteLine("Phan tu lon nhat: " + p.getMax(arr, n));
            Console.WriteLine("Phan tu be nhat: " + p.getMin(arr, n));
            Console.WriteLine("So phan tu le trong mang: " + p.getCountOddNumber(arr, n));
            Console.WriteLine("So phan tu am trong mang: " + p.getCountNegativeNumber(arr, n));
            Console.WriteLine("Tong cac phan tu trong mang: " + p.getTotal(arr, n));
            Console.WriteLine("Tong cac phan tu o vi tri chan trong mang: " + p.getTotalEvenIndex(arr, n));
            p.printPrimeNumber(arr, n);
            Console.WriteLine("So luong so nguyen to trong mang: " + p.getCountPrimeNumber(arr, n));
            Console.WriteLine("Tong cac so nguyen to trong mang: " + p.getTotalPrimeNumber(arr, n));
            p.printSquareNumber(arr, n);
            Console.WriteLine("Tong cac so chinh phuong trong mang: " + p.getTotalSquareNumber(arr, n));
            p.printPerfectNumber(arr, n);
            int x;
            Console.Write("Nhap phan tu x, tim vi tri dau tien cua x trong mang\nx = ");
            x = int.Parse(Console.ReadLine().ToString());
            int kiemTra = p.getFirstPosition(arr, n, x);
            if (kiemTra == -1)
            {
                Console.WriteLine("Khong tim thay {0} trong mang!", x);
            }
            else
            {
                Console.WriteLine("Vi tri xuat hien dau tien cua {0} trong mang: {1}", x, kiemTra);
            }
            Console.Write("Nhap phan tu x, dem so lan xuat hien cua x trong mang\nx = ");
            x = int.Parse(Console.ReadLine().ToString());
            int count = p.getCountEqual(arr, n, x);
            Console.WriteLine("So lan xuat hien cua {0} trong mang: {1}", x, count);
            Console.Write("\nNhap phan tu x, in tat ca cac vi tri cua no trong mang\nx = ");
            x = int.Parse(Console.ReadLine().ToString());
            p.printIndexByValue(arr, n, x);
            Console.Write("\nNhap phan tu x, them vao cuoi mang\nx = ");
            x = int.Parse(Console.ReadLine().ToString());
            p.insertLast(ref arr, ref n, x);
            p.print(arr, n);
            Console.Write("\nNhap phan tu x, them vao dau mang\nx = ");
            x = int.Parse(Console.ReadLine().ToString());
            p.insertFirst(ref arr, ref n, x);
            p.print(arr, n);
            Console.Write("\nNhap phan tu x, them vao vi tri thu k\nx = ");
            x = int.Parse(Console.ReadLine().ToString());
            Console.Write("\nk= ");
            int k;
            do
            {
                k = int.Parse(Console.ReadLine().ToString());
            } while (k <= 0 || k >= n);
            p.insertAt(ref arr, ref n, x, k);
            p.print(arr, n);
            Console.Write("\nNhap vi tri k(0<k<n), in phan tu tai k\nk = ");
            do
            {
                k = int.Parse(Console.ReadLine().ToString());
            } while (k <= 0 || k >= n);
            Console.WriteLine($"{k+1} = {arr[k]}");
            Console.WriteLine("Xoa phan tu cuoi mang: ");
            p.removeLast(arr, ref n);
            p.print(arr, n);
            Console.WriteLine("o0oXoa phan tu dau mang: ");
            p.removeFirst(ref arr, ref n);
            p.print(arr, n);
            Console.Write("\nNhap vi tri k(0<k<n), xoa phan tu tai k\nk = ");
            do
            {
                k = int.Parse(Console.ReadLine().ToString());
            } while (k <= 0 || k >= n);
            p.removeAt(ref arr, ref n, k);
            p.print(arr, n);
            Console.Write("\nNhap phan tu x, xoa phan tu x dau tien trong mang\nx = ");
            x = int.Parse(Console.ReadLine().ToString());
            p.removeFirst(ref arr, ref n, x);
            p.print(arr, n);
            Console.Write("\nNhap phan tu x, xoa tat ca phan tu x trong mang\nx = ");
            x = int.Parse(Console.ReadLine().ToString());
            p.removeAll(ref arr, ref n, x);
            p.print(arr, n);
            Console.WriteLine("Sap xep mang tang dan");
            p.ascSort(ref arr, n);
            p.print(arr, n);
            Console.WriteLine("Sap xep mang giam dan");
            p.descSort(ref arr, n);
            p.print(arr, n);
            Console.ReadKey(true);
        }
    }
}
    

