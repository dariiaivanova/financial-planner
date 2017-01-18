using financialplanner.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category("beach"),
                new Category("car"),
                new Category("car"),
                new Category("beach"),
                new Category("car"),
                new Category("car"),
                new Category("beach"),
                new Category("car")
            };

            // create child
            var parent1 = categories.ElementAt(3);
            var child1_0 = new Category(parent1, "1_0");
            var child1_1 = new Category(parent1, "1_1");
            var child1_2 = new Category(parent1, "1_2");
            var child1_1_0 = new Category(child1_1, "1_1_0");
            var child1_1_0_0 = new Category(child1_2, "1_1_0_0");

            // create child
            var parent2 = categories.ElementAt(4);
            var child2_0 = new Category(parent2, "2_0");
            var child2_1 = new Category(parent2, "2_1");
            var child2_2 = new Category(parent2, "2_2");
            var child2_1_0 = new Category(child2_1, "2_1_0");
            var child2_1_0_0 = new Category(child2_2, "2_1_0_0");

            // show result
            Print(categories.ToArray());
            Print(parent1, child1_0, child1_1, child1_2, child1_1_0, child1_1_0_0);
            Print(parent2, child2_0, child2_1, child2_2, child2_1_0, child2_1_0_0);

            //stop
            Console.ReadKey();
        }

        private static void Print(params Category[] categories)
        {
            foreach (var category in categories)
            {
                ImageSource image = category.Image;
                Console.WriteLine(category.Name + " : " + image + " (with hashcode): " + image.GetHashCode());
            }
            Console.WriteLine("______________________________________________________");
        }
    }
}
