
using System.Data;
using System.Reflection.Metadata;

namespace advancedc_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Q1: What is a generic class? Why use generics?

            //هو عباره عن اني بخليه بشكل عام واحد نوع داتا تايب لما اجي استخدم الكلاس ده وبعد تحديد داتا اي حاجه كنت مسميها ب اسم جينيريك بتتحول للي كتبته
            // beteer performance , readsabilty , وعدم تكرار الكود لكل داتا تايب
            #endregion
            #region advancedc#q2
            //Q2: Write a generic class Container<T> with Add and Get methods.
            //     public class tese<t>
            //{
            //}
            // public t testmethod<t>(t value){
            //
            // }
            #endregion
            #region avancedc#q3
            //Q3:What are multiple type parameters? Write Pair<TKey,TValue >.
            //     public class tese<Tkey,Tvalue>
            //{
            //}
            #endregion
            #region correctavancedc#q4
            //Q4: What is a generic method? Write Swap<T> method.
            //public void swap<T>(ref T a ,ref T b)
            //{
            //    T temp;
            //    temp = a;
            //    a = b;
            //    b = temp;            
            //}
            #endregion
            #region advancedc#q5
            //Q5: Write a generic method FindMax<T> that finds maximum value

            //public T findmax<T>(T[] arravalue) where T:IComparable<T>
            //{
            //    T res = arravalue[0];

            //    for (int i =0;i<arravalue.Length;i++)
            //    {
            //        if (res.CompareTo(arravalue[i]) < 0)
            //        {
            //            res = arravalue[i];
            //        }

            //    }

            //    return res;
            //}
            #endregion
            #region advancedc#q6
            //Q6: What is a generic interface? Write IRepository<T>.
            // نفس فكره الجينريك بس الفرق اني هخليه انترفيس فاي حد يمضي العقد يحدد نوع الداتا واي 
            // method signture  بتعتمد علي نوع داتا فهتتحول للنوع الي حدده لما جيت امضي العقد
            //  //public interface test<T>
            //{

            //}
            #endregion
            #region advancedc#q7
            //Q7: What is the 'struct' constraint? Write an example.
            //  structبجبر ان اي نوع يتم تحديده يبقي 
            //public class test<T> where T: struct { }
            #endregion
            #region advancedc#q8
            //Q8: What is the 'class' constraint? Write an example.
            //  class ان اي نوع يتم تحديده يبقي 
            //public class test<T> where T: class { }
            #endregion
            #region advancedc#q9
            //Q9: What is the 'new()' constraint? Write an example.
            //  where t is exist paramterless constructor 
            //public class test<T> where T: new() { }
            #endregion

        }




    }

  
}
