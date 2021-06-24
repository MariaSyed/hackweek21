using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onBowlCollide : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
	{
        if (Recipes.getIngredients().Contains(collision.gameObject.tag)) {
            var order = GameObject.FindObjectOfType<Order>();
            order.bowlContents.Add(collision.gameObject.tag);  
            Destroy(collision.gameObject);   
        }
	}
}
