using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.Demo02
{
    interface IDemo
    {
        void a();
    }

    interface IAnDemo
    {
        void a();
        void c();
    }

    class Demo : IDemo, IAnDemo
    {
        void IDemo.a()
        {
        }
        void IAnDemo.a()
        {
        }
        public void c()
        {
        }
    }
}
