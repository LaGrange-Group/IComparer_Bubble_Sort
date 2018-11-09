using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparer_Bubble_Sort
{
    public class SortList : IComparer
    {
        public List<int> intList;
        public SortList()
        {
            intList = new List<int>() { 5, 2, 3, 1, 4 };
        }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public dynamic Sort()
        {

            List<int> listSorted = new List<int>();

            return listSorted;
        }
    }
}
