using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Sharpie_set
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reuse your Sharpie class
            //Create SharpieSet class
            //it contains a list of Sharpie
            //Add method CountUsable() -> sharpie is usable if it has ink in it
            //Add method RemoveTrash() -> removes all unusable sharpies

            SharpieSet sharpiset = new SharpieSet();            
            Sharpie sharpi1 = new Sharpie("blue", 20, "sharpi1");
            Sharpie sharpi2 = new Sharpie("red", 60, "sharpi2");
            Sharpie sharpi3 = new Sharpie("yellow", 40, "sharpi3");
            Sharpie sharpi4 = new Sharpie("black", 80, "sharpi4");
            sharpiset.SharpieList.Add(sharpi1);
            sharpiset.SharpieList.Add(sharpi2);
            sharpiset.SharpieList.Add(sharpi3);
            sharpiset.SharpieList.Add(sharpi4);

            sharpi1.Use();
            sharpi3.Use();
            sharpiset.CountUsable(sharpiset.SharpieList);
            sharpiset.RemoveTrash(sharpiset.SharpieList);
            sharpiset.PrintOutSharpieList(sharpiset.SharpieList);
            Console.ReadLine();
        }
    }
}
