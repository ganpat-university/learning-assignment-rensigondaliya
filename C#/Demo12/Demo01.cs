using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.Demo01
{
    interface IDemo
    {
        void a();
    }
    interface IAnDemo
    {
        void b();
        void c();
    }

    class Demo : IDemo, IAnDemo
    {
        public void a()
        {

        }

        public void b()
        {

        }

        public void c()
        {

        }
    }
}
