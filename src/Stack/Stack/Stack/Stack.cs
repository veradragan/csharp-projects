using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStack
{
    public class Stack
    {
        private readonly List<object> _stackList;

        public Stack()
        {
            _stackList = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();

            _stackList.Add(obj);
        }

        public object Pop()
        {
            if (_stackList.Count == 0)
                throw new InvalidOperationException(message: "All objects have been deleted");
            
            var last = _stackList.Last<object>();//i could also write var index = _stackList.Count - 1
                                                 //and _stackList.RemoveAt(index) and return it var toRetrurn = _stackList[index]; return (toReturn)
            _stackList.Remove(last);
           
            return last;
        }

        public void Clear()
        {
            _stackList.Clear();
        }
    }

}
