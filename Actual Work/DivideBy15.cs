using System;
using System.Collections.Generic;
using System.Text;

namespace Actual_Work
{
    public class DivideBy15
    {
        public bool IsDivideBy15(int x)
        {
            if (x % 3 == 0 && x % 5 == 0) return true;
            return false;
        }
    }
}
