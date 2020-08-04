using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class InheritanceDemo : AccessDemo
    {
        public void Demo()
        {
            AccessDemo demo = new AccessDemo();
            // instance tida bisa akses:
            demo.PrivateProtectedDemo();
            demo.ProtectedDemo();
            demo.ProtectedInternalDemo();
            demo.InternalDemo();

            // method bisa akses melalui instance hanya untuk:
            demo.PublicDemo();

            // tidak bisa akses methode  ==>
            PrivateDemo()
            PrivateProtectedDemo();
            InternalDemo();

            // Method bisa diakses :
            ProtectedDemo();
            ProtectedInternalDemo();            
            PublicDemo();

        }
    }
}
