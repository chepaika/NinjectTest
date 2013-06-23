using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel ninjectKernel = new StandardKernel();
        }
    }
}
