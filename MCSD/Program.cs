using System;

namespace MCSD
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            DataTypes(); // #1
            Operators(); // #2             
            Expression(); // #3            
            TypeCasting(); // #4
            Arrays(); // #5 
            ProgramFlow(); // #6
            Loops(); // #7
            JumpStatements(); // #8
            Methods();  // #9

            // #10 Types in C#
            // #11 Understand Types

            // #12 Create Types
            // #12a Enum
            // #12b Struct
            // #12c Class


            // Value Type - type is defined by either struct or enum , it holds data in its own memory
            // Reference Type - type is defined by either class, interface or delegate, it holds a pointer to memory location that contains data called reference type.

            // ### Memory Locations
            // 1. Heap
            // 2. Stack
            // 3. Registers

            // Special Types in C#
            // 1. System.Object type - 
            /* inherited by all type in .net
              a. Equals
              b. Finalize
              c. GetHashCode
              d. ToString
            */

            // 2. anonymous type
            var anonymous = new
            {
                Age = 34
            };
            Console.WriteLine($"Age is {anonymous.Age}");

            // 3. dynamic type - can store values of different types with the same dynamic variable. can change type at runtime 

            // 4. nullable type
            /*
               bool? isMarried = null;
               bool married = isMarried ?? false;
            */

            // 5. static type

            //static class Helper
            //{
            //    public static int age;
            //    static Helper()
            //    {
            //        age = 22;
            //    }
            //}


        // #13 Types and Memory Management
        // #14 Special Types in C#
        // #15 Type Conversion


        Console.ReadLine();
        }

        private static void Methods()
        {
            // #1 Named Argument
            // #2 Optional Argument 

            // Pass by Reference with ref keyword , (must be initialized)
            void PassByRef(ref int i)
            {
                i = i + 1;
            }
            int j = 0;
            PassByRef(ref j);
            Console.WriteLine($"J is:{j}");
            // J is:1

            // Pass by Reference with out keyword , (we can pass none initialized)
            void OutMethod(out int i)
            {
                i = 1;
            }
            int k;
            OutMethod(out k);
            Console.WriteLine($"J is:{j}");
            //J is:1

            // #3 params array - to pass unlimited method argument
            int Sum(params int[] args)
            {
                int add = 0;
                foreach (int item in args)
                {
                    add += add + item;
                }
                return add;
            }
        }

        private static void JumpStatements()
        {
            // #1 Goto
            // #2 Break 
            // #3 Continue - continue to next iteration of loop
            // #4 Return
            // #5 Throw   

            // Goto
            // labelCheckPoint:
            // goto labelCheckPoint;

            // - Goto in for loop:
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] == 8)
                {
                    goto ControlDrop;
                }
                Console.WriteLine($"Continue:{numbers[i]}");
            }

            Console.WriteLine("This is after For Loop");
            ControlDrop:
            Console.WriteLine("The number is 8");
            // Continue: 1
            // Continue: 2
            // Continue: 3
            // Continue: 4
            // Continue: 5
            // Continue: 6
            // Continue: 7
            // The number is 8

            // - GoTo in foreach loop
            string[] strs = new string[] { "John Lloyd", "Ellen", "PitBulls", "APBT" };
            foreach (var str in strs)
            {
                if (str == "Ellen")
                {
                    goto Deftones;
                }
                Console.WriteLine(str);
            }
            Console.WriteLine("Don't do drugs");
            Deftones:
            Console.WriteLine($"Deftones Here!!!");
            Console.WriteLine("finish");

            // John Lloyd
            // Deftones Here!!!
            // finish

            // Break
            // Continue
            // Return
            // Throw        
        }

        private static void Loops()
        {
            // while loop
            // do-while loop
            // for loop
            // foreach loop
        }

        private static void ProgramFlow()
        {
            DecisionStructure();
            DecisionOperators();
        }

        private static void DecisionOperators()
        {
            // Conditional Operator (?:)
            
            // Null Coalescing Operator (??)
            string name = null;
            string username = name ?? "user"; // <-- set value "user" in username if "name" is null
        }

        private static void DecisionStructure()
        {
            // if {}
            // if-else {}
            // if-else if {}
            // switch {}
        }

        private static void Arrays()
        {
            SingleDimensionalArray();
            MultiDimensionalArray();
            JaggedArray();
        }

        private static void JaggedArray()
        {
            int[][] jagged = new int[4][];

            jagged[0] = new int[2];
            jagged[1] = new int[3];
            jagged[2] = new int[4];
            jagged[3] = new int[5];

            int[][] jagged2 =
            {
                new int[]{4,5},
                new int[]{6,7,8},
                new int[]{9,10,11},
                new int[]{12,13,14,15}
            };
        }

        private static void MultiDimensionalArray()
        {
            int[,] numbers = new int[2, 5];
            int[,] numbers2 = new int[2, 5]
            {
                {2,3,4,5,6 },
                {1,2,3,4,5 }
            };

            for (int row = 0; row < numbers2.GetLength(0); row++)
            {
                for (int col = 0; col < numbers2.GetLength(1); col++)
                {
                    Console.WriteLine(numbers2[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void SingleDimensionalArray()
        {
            string[] friends = new string[4];
            friends[0] = "Julius";
            friends[1] = "Bacosa";

            string[] friends2 = { "Julius", "Bacosa" };

            string[] friends3 = new string[4] { "Julius", "Bacosa" , "Genghis", "Khan"};
        }

        private static void DataTypes()
        {
            int i = 1; // 4 bytes
            float f = 1f; // 4 bytes
            double d = 1d; // 8 bytes
            char c = 'A'; // 2 bytes
            byte b = 5; // 8 bits
            string str = "Dev"; // (2 bytes) * str length
            bool bl = true; // 1 byte
        }

        private static void Operators()
        {
            // #2 Operators
            // Arithmetic Operator * / + - %            
            // Relational Operator > < == != >= <=            
            // Boolean Logical Operator && || !
        }

        public static void Expression()
        {
            // Expression in C#
            int i = 4;
            int j = (i * 4) + 3;
            Console.WriteLine(j);

        }

        public static void TypeCasting()
        {            
            ImplicitConversion();
            ExplicitConversion();

            // var is an implicit conversion
        }

        private static void ExplicitConversion()
        {
            double d = 3.1417;
            int i = (int)d;

            string s = "22";
            int age = int.Parse(s);
        }

        private static void ImplicitConversion()
        {
            // Implicit Conversion
            int i = 10;
            double d = i;

            object o = new Program();
        }
    }
}
