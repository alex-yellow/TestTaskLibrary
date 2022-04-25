using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskLibrary
{
    class TriangleExcept : Exception
    {
        public TriangleExcept(string message) : base(message)
        {

        }
    }
}
