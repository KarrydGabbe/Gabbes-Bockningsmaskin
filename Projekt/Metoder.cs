using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt
{
    class Metoder{
        public static void tremmplåt()
        {
            Console.WriteLine("Plockar 3 mm plåt");
        }
        public static void tvåmmplåt()
        {
            Console.WriteLine("Plockar 2 mm plåt");
        }
        
        public static int plåt_åtgång(int a, int b ,int OY)
        {
            int OX = a+b;
            int PlåtX = 1500;
            int PlåY = 1000;
            
            int XAntal1 = OX/PlåtX;
            int YAntal1 = OY/PlåY;
            int Antal1 =YAntal1*XAntal1;
            
            int XAntal2 = OY/PlåtX;
            int YAntal2 = OX/PlåY;
            int Antal2 =XAntal2*YAntal2;

            if(Antal1>=Antal2)
            {
                return(1);

            }
            else
            {
                return(2);
            

            }
        }
        public static int Bockning(int T, int L, int PK, int KX,int i)
        {
            if (i ==0)
            {
                Console.WriteLine(" Testplåten bockas "+KX +"mm in på plåten med trycket " + T*PK* (L*10) + " tryckenheter");
            }
            else
            {
                Console.WriteLine("Plåt "+ i +" bockas "+KX +"mm in på plåten med trycket " + T*PK* (L*10) + " tryckenheter");
            }
            int vinkel = 90; //sifran 90 är en placeholder där den faktiska vinkeln som är uppmätt ska hamna fär att senare korochera tryckkraften
            Console.WriteLine("Vinkeln mättes till "+vinkel);
            return(90/vinkel);
        }

        public static int palletering(int KX, int KY,int L)
        {
            double Hypotenusa = System.Math.Sqrt(KX*KX+KY*KY);

            double L1 = 1200/Hypotenusa;
            double B1 = 800/L;
            double A1 = L1*B1;

            double L2 = 1200/L;
            double B2 = 800/Hypotenusa;
            double A2 = L1*B1;

            if(A1<= A2)
            {
                Console.WriteLine("Vinkeljärnen packas längs med pallen");
            
            }
            else
            {
                Console.WriteLine("Vinkeljärnen packas tvärs på pallen");

            }





            return(1);
        }
    }
}