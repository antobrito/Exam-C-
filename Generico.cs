using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    public class Generico<T> where T : class
    {
        private List<T>  IList = new List<T>();



      public void  add(  T[] Items )

      {



            IList.AddRange( Items );

        }


        public T getItem(T Item)

        {



            return IList.FirstOrDefault(Item);

        }


        public List<T> getAllSorted()

        {



            return IList.Sort();


        }



    }
}
