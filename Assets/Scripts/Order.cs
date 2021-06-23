using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{

    public List<GameObject> orders;

    // Start is called before the first frame update
    void Start()
    {
        var currentOrder = Instantiate(getRandomOrder(), new Vector2(-6.8f, 3.5f), Quaternion.identity);
        currentOrder.transform.localScale = new Vector2(1, 1);

        var upcomingOrder1 = Instantiate(getRandomOrder(), new Vector2(-2.8f, 3.5f), Quaternion.identity);
        var upcomingOrder2 = Instantiate(getRandomOrder(), new Vector2(0.5f, 3.5f), Quaternion.identity);
        upcomingOrder1.transform.localScale = new Vector2(1, 1);
        upcomingOrder2.transform.localScale = new Vector2(1, 1);

        Debug.Log(currentOrder.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject getRandomOrder() {
        return orders[Random.Range(0, orders.Count)];
    }
}
