using System.Collections.Generic;

namespace delegates
{
    public class data
    {
        //public static List<int> Retrieve(List<int> list, int step)
        //{
        //    var newList = new List<int>();

        //    for (int i = 0; i < list.Count; i+=step)
        //    {
        //        newList.Add(list[i]);
        //    }

        //    return newList;
        //}


        public string GetType<T>(T element)
        {
            return element.GetType().Name;
        }
    }
}
