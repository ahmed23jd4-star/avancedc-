
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
            #region advancedc#q10
            //Q10: What is the interface constraint? Write an example.
            //where t implment interface 
            //public class test<T> where T: Itest { }     ///// such Itest is interface 
            #endregion
            #region advancedc#q11
            //Q11: What is the base class constraint? Write an example.
            // يعني وارث من كلاس معين
            //public class test<T> where T: baseclass { }
            #endregion
            #region advancedc#q12
            //Q12: How do you apply multiple constraints? Write an example.
            //public class test<T> where T: baseclass,Itest,Ianotherinterface,new() { }

            #endregion
            #region advancedc#q13
            //Q13: What does the 'default' keyword do in generics ?
            // يعني رجعلي القيمه الافتراضيه لنوع البيانات الي انا هحدده بعدين 
            #endregion
            #region advancedc#q14
            //Q14: Write a SafeList < T > that returns default when the index is invalid.

            //public T safelist<T>(T list)
            //{
            //    //if valid
            //    //return 

            //    //if not valid
            //    return default (T) ;

            //}
            #endregion
            #region advancedc#q15
            //Q15: What is covariance? Explain the 'out' keyword.
            // public interface test <out T> {}
            //هو عباره عن انترفيس جينيريك بس بحدد ان نوع الجينيريك يبقي OUT بس 
            //يعني T is return type of methods 
            #endregion
            #region advancedc#q16
            //Q16: What is contravariance? Explain the 'in' keyword.
            // public interface test <in T> {}
            // can use T in paramater in method or any input but can,t use output
            
            #endregion

        }





    }



}
