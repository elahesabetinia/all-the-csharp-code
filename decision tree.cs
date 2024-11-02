using System;

namespace DecisionTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the decision tree(yes/no)");

            // گره اول: سؤال اولیه
            Console.WriteLine("are you happy for being alive?");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                // گره دوم: گزینه‌های بعدی برای پاسخ "بله"
                Console.WriteLine("do have any dream or goal in your life");
                string answer1 = Console.ReadLine().ToLower();

                if (answer1 == "yes")
                {
                    Console.WriteLine("Keep trying :) Disney says if you can dream it, you can do it");
                }
                else
                {
                    Console.WriteLine("How can you be alive and not have a dream? The human purpose of being alive is higher than just being alive.");
                }
            }
            else if (response == "no")
            {
                // گره دوم: گزینه‌های بعدی برای پاسخ "خیر"
                Console.WriteLine("Do you feel worthless?");
                string xxx = Console.ReadLine().ToLower();

                if (xxx == "yes")
                {
                    Console.WriteLine("Don't worry, there is a Japanese proverb that says: When you are a child, you are a bloomer, when you are a teenager, you are a genius...but as an adult, you are just a failure...that's what poverty is. Nature is not something that others can put a price on.");
                }
                else
                {
                    Console.WriteLine(".I'm glad that at least you believe in yourself :) I agree that life and its people are not interesting things, but being alive is a gift that you have to pay a heavy price to understand its value.");
                }
            }
            else
            {
                Console.WriteLine("plese answer just with yes or no.");
            }
        }
    }
}
