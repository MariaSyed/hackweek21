using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipes : MonoBehaviour
{


    public static Dictionary<string, List<string>> get() {
        Dictionary<string, List<string>> recipes = new Dictionary<string, List<string>>();

        List<string> chocolateCake = new List<string>();
        chocolateCake.Add("Egg");
        chocolateCake.Add("Flour");
        chocolateCake.Add("Chocolate");
        recipes.Add("ChocolateCake", chocolateCake);

        List<string> strawberryCake = new List<string>();
        strawberryCake.Add("Egg");
        strawberryCake.Add("Flour");
        strawberryCake.Add("Strawberry");
        recipes.Add("StrawberryCake", strawberryCake);

        List<string> milkshake = new List<string>();
        milkshake.Add("Milk");
        milkshake.Add("Sugar");
        recipes.Add("Milkshake", milkshake);

        List<string> bread = new List<string>();
        bread.Add("Flour");
        bread.Add("Flour");
        recipes.Add("Bread", bread);

        return recipes;
    }

     public static List<string> getIngredients() {
        List<string> ingredients = new List<string>();

        ingredients.Add("Egg");
        ingredients.Add("Flour");
        ingredients.Add("Chocolate");
        ingredients.Add("Strawberry");
        ingredients.Add("Milk");
        ingredients.Add("Sugar");

        return ingredients;
    }
}
