using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloads
{
    public class ZClass
    {
        #region FIELDS
        int _f1, _f2;
        #endregion FIELDS

        public ZClass(int f1, int f2)
        {
            _f1 = f1; _f2 = f2;
        }

        public static ZClass operator+(ZClass lhs, ZClass rhs)
        {
            return new ZClass(lhs._f1 + rhs._f1, lhs._f2 + rhs._f2);
        }

        public static ZClass operator+(ZClass lhs, int rhs)
        {
            return new ZClass(lhs._f1 + rhs, lhs._f2 + rhs);
        }

        public override string ToString()
        {
            return string.Format("f1:{0}, f2:{1}", _f1, _f2);
        }

        public int Total
        {
            get
            {
                return _f1 + _f2;
            }
        }

        public static ZClass operator-(ZClass lhs, ZClass rhs)
        {
            return new ZClass(lhs._f1 - rhs._f1, lhs._f2 - rhs._f2);
        }

        public static ZClass operator - (ZClass lhs, int rhs)
        {
            return new ZClass(lhs._f1 - rhs, lhs._f2 - rhs);
        }


    }
}
