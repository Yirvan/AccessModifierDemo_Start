using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CallingDemo
    {
        private void MakeDemoCall()
        {
            AccessDemo demo = new AccessDemo();
            
            // instance tida bisa akses ==>
            demo.PrivateProtectedDemo(); 
            demo.ProtectedDemo();

            // method bisa akses melalui instance hanya untuk:
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
