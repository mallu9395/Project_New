using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate T MyDelegate<T>() where T : new();
    public class Container<P> where P : struct
    {
        private P _item;
        MyDelegate<int> _delegate;
        public Container(P a,P a1)
        {
            _delegate = new MyDelegate<int>(DisplayItemInfo);
            _delegate();
        }

        public int DisplayItemInfo()
        {
            return 0;
        }
    }

}
