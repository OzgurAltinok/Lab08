using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            OzelKuyruk x = new OzelKuyruk();
            x.KuyrukIlkHal(1);
            x.KuyrukIlkHal(5);
            x.KuyrukIlkHal(7);
            x.KuyrukIlkHal(9);
            x.KuyrukIlkHal(16);
            x.KuyrukIlkHal(24);
            x.KuyrukIlkHal(7);

            x.Enqueue(6);
            x.Dequeue();
            x.Goster();
                
            //Queue y = new Queue();
            //y.Enqueue(1);
            //y.Enqueue(5);
            //y.Enqueue(7);
            //y.Enqueue(9);
            //y.Enqueue(16);
            //y.Enqueue(24);
            //y.Enqueue(7);

            //Çeşitli ekleme ve çıkarma yaptıktan sonra kuyrukların görüntüsünü adım adım ekranda gösteriniz
            //yukarıdaki eklemeler

            Console.ReadKey();
        }
    }
}
