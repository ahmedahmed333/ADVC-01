namespace ADVC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region   Q1

            //     Q1: What is a generic class? Why use generics?

            // A generic class is a class that is defined with type paramas , allowing it to work with different data types without rewriting the class , generices provide code reusability , and type safety.

            #endregion

            #region   Q2

            // Q2: Write a generic class Container<T> with Add and Get methods

            Container<int> cont = new Container<int>();

            cont.Add(10);
            Console.WriteLine(cont.Get()); // 10
            #endregion


            #region   Q3
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue >.
            // part one : 
            // Multiple type params allow a generic class or method to work with more than one data type.


            // part two :

            Pair<int, string> pair = new Pair<int, string>(1, "ahmed");

            #endregion


            #region   Q4
            //Q4: What is a generic method? Write Swap<T> method.
            // A generic method is a method that can work with different data type using a type params 

            //Swap method in Container class


            #endregion

            #region   Q5

            // Q5: Write a generic method FindMax<T> that finds maximum value

            static T FindMax<T>(T a, T b) where T : IComparable<T>
            {
                return a.CompareTo(b) > 0 ? a : b;
            }
            int max = FindMax(10, 20);
            Console.WriteLine(max);

            #endregion

            #region   Q6 
            // Q6: What is a generic interface? Write IRepository<T>.

            //A generic interface is an interface that uses a type parameter, allowing it to work with different data types.


            #endregion

        }
    }
}
