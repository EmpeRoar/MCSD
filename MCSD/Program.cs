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

            Console.ReadLine();
        }

        private static void ProgramFlow()
        {
            DecisionStructure();
        }

        private static void DecisionStructure()
        {
            throw new NotImplementedException();
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
