using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour
{

    public List<GameObject> orders;
    public GameObject bowl;
    public Text pointsBox;
    public Text bowlContentsBox;

    public List<string> bowlContents;
    public int totalPoints;

    private List<GameObject> ordersQueue;
    private List<string> currentRecipe;
    private GameObject order1;
    private GameObject order2;
    private GameObject order3;

    // Start is called before the first frame update
    void Start()
    {
        ordersQueue = new List<GameObject>(3);
        bowlContents = new List<string>();
        totalPoints = 0;

        ordersQueue.Add(getRandomOrder());
        ordersQueue.Add(getRandomOrder());
        ordersQueue.Add(getRandomOrder());

        currentRecipe = Recipes.get()[ordersQueue[0].gameObject.tag];

        renderOrders();

        bowl.AddComponent<onBowlCollide>();
    }

    // Update is called once per frame
    void Update()
    {
        bowlContentsBox.text = string.Join(", ", bowlContents);

        var isOrderComplete = CompareLists(currentRecipe, bowlContents);

        if (isOrderComplete) {
            onOrderComplete();
        } else {
            var isOrderFail = bowlContents.Count > currentRecipe.Count;

            if (isOrderFail) {
                onOrderFail();
            }
        }

        Debug.Log(totalPoints);
        pointsBox.text = "Points: " + totalPoints;
    }

    GameObject getRandomOrder() {
        return orders[Random.Range(0, orders.Count)];
    }

    void renderOrders() {
        Destroy(order1);
        Destroy(order2);
        Destroy(order3);

        order1 = Instantiate(ordersQueue[0], new Vector2(-6.5f, 3.5f), Quaternion.identity);
        order2 = Instantiate(ordersQueue[1], new Vector2(-6.5f, 1), Quaternion.identity);
        order3 = Instantiate(ordersQueue[2], new Vector2(-6.5f, -1.5f), Quaternion.identity);

        order1.transform.localScale = new Vector2(1, 1);
        order2.transform.localScale = new Vector2(1, 1);
        order3.transform.localScale = new Vector2(1, 1);
    }

    void popOrdersQueue() {
        ordersQueue[0] = ordersQueue[1];
        ordersQueue[1] = ordersQueue[2];
        ordersQueue[2] = getRandomOrder();
    }

    void onOrderComplete() {
        totalPoints += 1000;
        bowlContents = new List<string>();
        popOrdersQueue();
        renderOrders();
    }

    void onOrderFail() {
        bowlContents = new List<string>();
    }

     bool CompareLists<T> (List<T> list1, List<T> list2)
     {
         if (list1.Count != list2.Count)
             return false;
 
         foreach (var item in list1)
             if (list2.Find(i => i.Equals(item)) == null)
                 return false;
 
         foreach (var item in list2)
             if (list1.Find(i => i.Equals(item)) == null)
                 return false;
 
         return true;
     }
}
