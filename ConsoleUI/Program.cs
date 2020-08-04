using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessDemo demo = new AccessDemo();            
            // instance tida bisa akses ==>
            demo.PrivateProtectedDemo();
            demo.ProtectedDemo();
            demo.ProtectedInternalDemo();
            demo.InternalDemo();
            demo.PublicDemo();

            // tidak bisa akses ke methode
            PrivateProtectedDemo();
            ProtectedDemo();
            ProtectedInternalDemo();
            InternalDemo();
            PublicDemo();
        }
    }
}
