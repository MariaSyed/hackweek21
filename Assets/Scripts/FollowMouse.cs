using UnityEngine;
using System.Collections;
 
public class FollowMouse : MonoBehaviour {
 private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
 
    // Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update () {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.y = mousePosition.y < -1.0 ? mousePosition.y : -1.0f;
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
}
 