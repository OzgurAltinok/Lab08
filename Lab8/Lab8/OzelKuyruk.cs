using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class OzelKuyruk
    {
        ArrayList sayilar = new ArrayList();
        private static int elemanSayisi;

        public ArrayList Sayilar { get => sayilar; set => sayilar = value; }
        public static int ElemanSayisi { get => elemanSayisi; set => elemanSayisi = value; }

        public OzelKuyruk()
        {
            

        }

        public void KuyrukIlkHal(int Eleman)
        {
            Sayilar.Add(Eleman);
            ElemanSayisi++;
        }

        public void Enqueue(int YeniEleman)
        {
            //implemente edilecek

            for (int i = 0; i < ElemanSayisi; i++)
                if ((Int32)Sayilar[i] % 2 == 0)
                {
                    Sayilar.Insert(i + 1, YeniEleman);
                    ElemanSayisi++;
                    break;
                }

        }

        public void Goster()
        {
            for (int i = 0; i < ElemanSayisi; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }
             
        }

        public void Dequeue()
        {
            //implemente edilecek
            if(ElemanSayisi!=0)
            try
            {

                Sayilar.RemoveAt(ElemanSayisi);
		ElemanSayisi--;
            }

            catch(Exception e)
            {
                    Console.WriteLine(e);
            }

            //OzelKuyruk boş ise istisna fırlatacak
        }

        
    }
}
