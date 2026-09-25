using System.Data;
using System.Reflection.Metadata;

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
            #region   Q7
            // Q7: What is the 'struct' constraint? Write an example.

            // The struct constraint specifies that the type params must be a value type.
            static void print<T>(T value) where T : struct
            {
                Console.WriteLine(value);
            }


            #endregion


            #region   Q8
            //Q8: What is the 'class' constraint? Write an example.

            // The class constraint specifies that the type params must be a reference type.
            static void printClass<T>(T value) where T : class
            {
                Console.WriteLine(value);
            }
            #endregion


            #region   Q9
            // Q9: What is the 'new()' constraint? Write an example.

            // The new() constraint specifies that the type parameter must have a public parameterless constructor.

            static T Create<T>() where T : new()
            {
                return new T();
            }
            #endregion

            #region   Q10
            //Q10: What is the interface constraint? Write an example.


            // An interface constraint specific that the type params must implement a specific interface.
            static void PrintItem<T>(T item) where T : IPrintable
            {
                item.Print();
            }
            #endregion

            #region   Q11
            // Q11: What is the base class constraint? Write an example.


            // A base class constraint specifies that the type params must be a specific base class or dreive from that base class.


        class AnimalShelter<T> where T : Animal
        {
            public void announce(T animal) => animal.MakeSound();
        }

        #endregion


        #region   Q12
        //Q12: How do you apply multiple constraints? Write an example.

        // Multie constraints are chined with commas; new () must always come last;

        class Repository<T> where T : Animal, IIdentifiable, new()
        {
            public T CreateNew() => new T();
        }


        #endregion



        #region   Q13
        // Q13: What does the 'default' keyword do in generics?

        //  'default' returs the default value of T : 0 /false for value types ,  null for refernce types


        #endregion


        #region   Q14
        //Q14: Write a SafeList<T> that returns default when the index is invalid.

        //SafeList done 

        #endregion

        #region   Q15
        //Q15: What is covariance? Explain the 'out' keyword.

        // Covariance allows a more derived type to be used where a base type is expected, 'out' marks T as output-only.


        #endregion

        #region   Q16 
        // Q16: What is contravariance? Explain the 'in' keyword. 

        //  Contravariance allows a base type to be used where a derived type is expected, 'in' marks T as input-only.

        #endregion

        #region   Q17 
        //Q17: What is the difference between covariance and contravariance?

        // Covariance (out) affects return types (derived -> base), contravariance (in) affects parameter types (base -> derived).
        #endregion

        #region   Q18 
        //Q18: How do static members work in generic types?


        // Each closed generic type (e.g. Counter<int>, Counter<string>) gets its own separate copy of static members.

        #endregion

        #region   Q19
        // Q19: How can you inherit from a generic class?

        // You can either fix the type parameter (closed) or keep it generic and pass it along (open).

        #endregion



      


    }




}

}
