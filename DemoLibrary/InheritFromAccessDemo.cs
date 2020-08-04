using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class InheritFromAccessDemo: AccessDemo
    {
        public void Test()
        {
            AccessDemo demo = new AccessDemo();
            // instance tida bisa akses ==>
            demo.PrivateProtectedDemo();
            demo.ProtectedDemo();

            // method bisa akses melalui instance hanya untuk:
            demo.ProtectedInternalDemo();           
            demo.InternalDemo();
            demo.PublicDemo();

            // tidak bisa akses methode PrivateDemo() Ancestor
            PrivateProtectedDemo();
            ProtectedDemo();
            ProtectedInternalDemo();
            InternalDemo();
            PublicDemo();
            
            
        }
    }
}
