using System;
using System.Collections.Generic;

namespace delegates
{
    internal class Program
    {
        //private delegate List<int> GetListResult(List<int> list, int step);
        //private delegate string GetInfo<T>(T element);

        static void Main(string[] args)
        {
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var getSkippedElements = new GetListResult(data.Retrieve);
            //var resultList = getSkippedElements(list, 2);
            //for (int i = 0; i < resultList.Count; i++)
            //{
            //    Console.WriteLine(resultList[i]);
            //}
            //data data = new data();
            //var getType = new GetInfo<int>(data.GetType);
            //
            //GetInfo<int> getType1 = delegate (int element) { return element.GetType().Name; };
            ////
            //Console.WriteLine(getType1(5));


            Smt smt = new Smt();
        }
        public class Smt
        {
            public delegate void Calc(int num);
            private Calc testDelegateFunction;
            public Smt()
            {
                testDelegateFunction = MultiplyBy314;
                testDelegateFunction += DivideBy314;
                testDelegateFunction += Add314;
                testDelegateFunction += Minus314;

                testDelegateFunction(10);
            }

            public void MultiplyBy314(int num)
            {
                Console.WriteLine(num * 3.14);
            }
            public void DivideBy314(int num)
            {
                Console.WriteLine(num / 3.14);
            }
            public void Add314(int num)
            {
                Console.WriteLine(num + 3.14);
            }
            public void Minus314(int num)
            {
                Console.WriteLine(num - 3.14);
            }
        }
        
    }
}
