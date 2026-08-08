using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_4._01___Submission_of_C__Generics
{
    internal class Personalized_Meal_Plan_Generator
    {
        public static void Main(string[] args)
        {
            List<string> veggies = new List<string> { "Broccoli", "Carrots", "Spinach" };
            VegetarianMeal vegMeal = new VegetarianMeal("Vegetarian", 450, veggies);
            Meal<VegetarianMeal> breakfast = new Meal<VegetarianMeal>("Healthy Breakfast", vegMeal);
            GenerateMealPlan(breakfast);

            VeganMeal veganLunch = new VeganMeal("Vegan", 550, true, "Tofu");
            Meal<VeganMeal> lunch = new Meal<VeganMeal>("Power Lunch", veganLunch);
            GenerateMealPlan(lunch);

            KetoMeal ketoDinner = new KetoMeal("Keto", 650, 45, 10);
            Meal<KetoMeal> dinner = new Meal<KetoMeal>("Keto Dinner", ketoDinner);
            GenerateMealPlan(dinner);

            HighProteinMeal proteinSnack = new HighProteinMeal("High-Protein", 400, 35, "Chicken");
            Meal<HighProteinMeal> snack = new Meal<HighProteinMeal>("Post-Workout Snack", proteinSnack);
            GenerateMealPlan(snack);
        }

        static void GenerateMealPlan<T>(Meal<T> meal) where T : IMealPlan
        {
            if(meal.ValidateMeal())
            {
                Console.WriteLine($"\nMeal: {meal.mealName}");
                meal.plan.DisplayMealInfo();
                Console.WriteLine("Status: Validated");
            }
            else
            {
                Console.WriteLine($"Invalid meal: {meal.mealName}");
            }
        }
    }
    public interface IMealPlan
    {
        string mealType { get; set; }
        int calories { get; set; }
        void DisplayMealInfo();
    }

    public class VegetarianMeal : IMealPlan
    {
        public string mealType { get; set; }
        public int calories { get; set; }
        public List<string> vegetables;

        public VegetarianMeal(string mealType, int calories, List<string> vegetables)
        {
            this.mealType = mealType;
            this.calories = calories;
            this.vegetables = vegetables;
        }

        public void DisplayMealInfo()
        {
            Console.Write($"Type: {mealType}, Calories: {calories}, Vegetables: ");
            foreach(string veg in vegetables)
            {
                Console.Write($"{veg} ");
            }
            Console.WriteLine();
        }
    }

    public class VeganMeal : IMealPlan
    {
        public string mealType { get; set; }
        public int calories { get; set; }
        public bool hasNuts;
        public string proteinSource;

        public VeganMeal(string mealType, int calories, bool hasNuts, string proteinSource)
        {
            this.mealType = mealType;
            this.calories = calories;
            this.hasNuts = hasNuts;
            this.proteinSource = proteinSource;
        }

        public void DisplayMealInfo()
        {
            string nutInfo = hasNuts ? "Contains Nuts" : "Nut-Free";
            Console.WriteLine($"Type: {mealType}, Calories: {calories}, Protein: {proteinSource}, {nutInfo}");
        }
    }

    public class KetoMeal : IMealPlan
    {
        public string mealType { get; set; }
        public int calories { get; set; }
        public int fatGrams;
        public int carbGrams;

        public KetoMeal(string mealType, int calories, int fatGrams, int carbGrams)
        {
            this.mealType = mealType;
            this.calories = calories;
            this.fatGrams = fatGrams;
            this.carbGrams = carbGrams;
        }

        public void DisplayMealInfo()
        {
            Console.WriteLine($"Type: {mealType}, Calories: {calories}, Fat: {fatGrams}g, Carbs: {carbGrams}g");
        }
    }

    public class HighProteinMeal : IMealPlan
    {
        public string mealType { get; set; }
        public int calories { get; set; }
        public int proteinGrams;
        public string meatType;

        public HighProteinMeal(string mealType, int calories, int proteinGrams, string meatType)
        {
            this.mealType = mealType;
            this.calories = calories;
            this.proteinGrams = proteinGrams;
            this.meatType = meatType;
        }

        public void DisplayMealInfo()
        {
            Console.WriteLine($"Type: {mealType}, Calories: {calories}, Protein: {proteinGrams}g, Meat: {meatType}");
        }
    }

    public class Meal<T> where T : IMealPlan
    {
        public string mealName;
        public T plan;

        public Meal(string mealName, T plan)
        {
            this.mealName = mealName;
            this.plan = plan;
        }

        public bool ValidateMeal()
        {
            return plan.calories > 0 && plan.mealType != "";
        }
    }
}
