using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Mosh.Class.Constructor;

namespace Csharp_Mosh.Class
{
    public class Customer
    {
        public string Name;
        public int Id;
        public readonly List<Order> Orders=new List<Order>(); //readonly: the orders only could be initialize here, and it will show compile error in promote
        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id) //overloading
            //:this()
        {
            this.Id = id;
        }

        public Customer(int id,string name) //overloading: same name method with different signature
            :this(id)
        {
            
            this.Name = name;

        }

        public void Promotion()
        {
           // Orders = new List<Order>();
        }
    }
}
