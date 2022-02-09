using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.Demo03
{
    interface IDemo
    {
        void a();
    }

    interface IAnotherDemo : IDemo
    {
        void b();
    }
    class Demo2 : IAnotherDemo
    {
        void IDemo.a()
        {

        }

        void IAnotherDemo.b()
        {

        }
    }
    class Demo1 : IAnotherDemo
    {
        public void a()
        {

        }

        public void b()
        {

        }

    }
}
