using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11FindTheThirdElementFromLast
{
    class ThirdElementFromLast
    {
        LinkedList<object> list = new LinkedList<object>();


        public ThirdElementFromLast(string[] p)
        {
            foreach (string str in p) {
                list.AddLast(Convert.ToInt32(str));
            }
        }

        public string GetThirdElementFromLast()
        {
            LinkedListNode<object> it1 = list.First;
            LinkedListNode<object> it2 = list.First;
            int count = 1;
            while (it1 != null) {
                //Needed for it to find it one pass
                //Plan on return the it2 node so push the it1 node ahead a bit
                if (count == 1 || count == 2 || count ==3)
                {
                    count++;
                    it1 = it1.Next;
                }
                else {
                    count++;
                    it1 = it1.Next;
                    it2 = it2.Next;                
                }
            }
            return it2.Value.ToString();
        }
    }
}
