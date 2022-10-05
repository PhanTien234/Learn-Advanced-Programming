using System.Resources;
using System;

namespace Bt_chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Nhap chuoi ki tu ");
           string chuoi=Console.ReadLine();
           Console.WriteLine("Chuoi vua nhap: "+ chuoi);
           KiTuRiengLe(chuoi);
           DaoNguocChuoiKiTuRiengLe(chuoi);
           DemSoChuCacKiTuDacBiet(chuoi);
           DemSoNguyenAmPhuAm(chuoi);
           TimKiTuXuatHienNhieuNhat(chuoi);
        }
        static void KiTuRiengLe(string chuoi)
        {
            Console.Write("Chuoi sau khi tach: ");
            int i=0;
            while(i<chuoi.Length)
            {
                Console.Write(chuoi[i]+" ");
                i++;
            }
            Console.WriteLine();
        }
        static void DaoNguocChuoiKiTuRiengLe(string chuoi)
        {
            Console.Write("Chuoi sau khi tach va dao nguoc la: ");
            int i = chuoi.Length-1;
            while(i>=0)
            {
                Console.Write(chuoi[i]+" ");
                i--;
            }
            Console.WriteLine();

        }
        static void DemSoTu(string chuoi)
        {
            int dem=1;
            for(int i=0; i<chuoi.Length; i++)
            {
               if(chuoi[i] == ' ')
               {
                   dem++;
               }
            }
        }
        static void DemSoChuCacKiTuDacBiet(string chuoi)
        {
            int demSo=0, demChu=0, demKiTuDacBiet=0;
            for(int i=0; i<chuoi.Length; i++)
            {
                if(chuoi[i]>='a' && chuoi[i]<='z'|| chuoi[i]>='A'&& chuoi[i]<='Z')
                {
                    demChu++;
                }
                else if(chuoi[i]>=0&&chuoi[i]<=9)
                {
                    demSo++;
                }
                else
                {
                    demKiTuDacBiet++;
                }
            }
            Console.WriteLine("So chu cai trong chuoi la: " +demChu);
            Console.WriteLine("So chu so trong chuoi la: "+ demSo);
            Console.WriteLine("So ki tu dac biet trong chuoi la: " +demKiTuDacBiet);

        }
        static void DemSoNguyenAmPhuAm(string chuoi)
        {
            int demNguyenAm=0, demPhuAm=0;
            for(int i=0; i<chuoi.Length; i++)
            {
                if(chuoi[i] == 'e'|| chuoi[i]=='u'|| chuoi[i]=='o'||chuoi[i]=='a'||chuoi[i]=='i'||chuoi[i]=='U'||chuoi[i]=='E'||chuoi[i]=='O'||chuoi[i]=='A'||chuoi[i]=='I')
                {
                    demNguyenAm++;
                }
                else
                {
                    demPhuAm++;
                }
            }
            Console.WriteLine("So nguyen am trong chuoi la: "+ demNguyenAm);
            Console.WriteLine("so phu am trong chuoi: " +demPhuAm);

        }
        static void TimKiTuXuatHienNhieuNhat(string chuoi)
        {
            int[] chuoiMoi=new int[chuoi.Length];
            int kiTu=0, tuXuatHienNhieuNhat=0, b=0;
            for(int i=0; i<chuoi.Length; i++)
            {
                for(int j=i+1; j<chuoi.Length; j++)
                {
                
                    if(chuoi[i]!= ' '&& chuoi[j]!=' ')
                    {
                       if(chuoi[i]==chuoi[j])
                       {
                           kiTu++;
                       }
                    }
                }
                
                if(kiTu > tuXuatHienNhieuNhat)
                {
                    tuXuatHienNhieuNhat=kiTu;
                    b=i;
                }
                kiTu=1;
            }
            Console.WriteLine("Ki tu xuat hien nhieu nhat la " + chuoi[b] + " xuat hien " + tuXuatHienNhieuNhat + " lan ");
        }
    }
}
