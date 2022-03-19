namespace calculateCalorie
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your weight (kg)");
            int weight = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter your height (cm)");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please chose your gender \n (1) Woman \n (2) Man");
            int gender = Convert.ToInt32(Console.ReadLine());

            if (gender == 1)
            {
                double womanBmh = ( 10 * weight ) + ( 6.25 * height ) - ( 5 * age ) - 161;
                double calorieCounter = womanBmh * 1.375;
                Console.Write($"You daily calorie need : {calorieCounter}Kcal");
            }

            if (gender == 2)
            {
                double manBmh = ( 10 * weight) + ( 6.25 * height) - ( 5 * age) + 5;
                double calorieCounter = manBmh * 1.375;
                Console.Write($"You daily calorie need : {calorieCounter}Kcal");
            }
        }
    }
}