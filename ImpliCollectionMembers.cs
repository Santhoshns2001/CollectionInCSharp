using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFrameWork
{
    internal class ImpliCollectionMembers
    {

        public void ImpliArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5.3);
            arrayList.Add("santhosh");
            arrayList.Add(22);


            arrayList.AddRange(arrayList);
            arrayList.Insert(3, "hallo");

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }

        public void ImpliHashTable()
        {
            Hashtable hstable=new Hashtable();

           // hstable.a
        }


        public void ImpliDictionary()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "santhosh");
            dict.Add(2, "lokesh");
            dict.Add(3, "shuaib");



          //IList<int> keys=  dict.Keys();


            foreach(KeyValuePair<int,string> d in dict)
            {
                Console.WriteLine(d.Key+"->"+d.Value);
            }
        }

        internal void AddingNum()
        {
            List<int> list = new List<int>();

            //List<int> oddNumlist = new List<int>();
            //List<int> evenNumList = new List<int>();

            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            var evenCount = 0;
            var oddCount = 0;
            for(var i=0;i< list.Count;i++)
            {
                if (list[i] % 2 != 0)
                {
                    oddCount++;
                   // oddNumlist.Add(list[i]);
                }
                else
                    evenCount++;
              //  evenNumList.Add(list[i]);


            }
            // foreach for add and even.

            Console.WriteLine("the odd numbers in the list are :" +oddCount);
            Console.WriteLine("the even numbers from the list are :" + evenCount);

        }

        internal void FindMaxInString()
        {
            List<string> lst = new List<string>();

            lst.Add("santhosh");
            lst.Add("lokesh");
            lst.Add("shuiab");



            string max = lst[0];

            if (lst[0].Length > lst[1].Length)
                max = lst[0];
            else if (lst[1].Length > lst[2].Length)
                max = lst[1];
            else
                max= lst[2];


            Console.WriteLine("the maximum in the stirng  is :"+max);
        }
    }
}
