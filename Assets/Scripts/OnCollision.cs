using UnityEngine;
using UnityEngine.Events;

public class OnCollision : MonoBehaviour
{
	public string tagToCollideWith = "";
	public UnityEvent onCollisionEnter;
	public UnityEvent onCollisionStay;
	public UnityEvent onCollisionExit;

	void OnCollisionEnter2D(Collision2D collision)
	{
		CollisionEvent(onCollisionEnter, collision.gameObject);
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		CollisionEvent(onCollisionEnter, collision.gameObject);
	}

	void OnCollisionStay2D(Collision2D collision)
	{
		CollisionEvent(onCollisionStay, collision.gameObject);
	}

	void OnTriggerStay2D(Collider2D collision)
	{
		CollisionEvent(onCollisionStay, collision.gameObject);
	}

	void OnCollisionExit2D(Collision2D collision)
	{
		CollisionEvent(onCollisionExit, collision.gameObject);
	}

	void OnTriggerExit2D(Collider2D collision)
	{
		CollisionEvent(onCollisionExit, collision.gameObject);
	}

	void CollisionEvent(UnityEvent unityEvent, GameObject otherObject)
	{
		if (tagToCollideWith != "" && otherObject.tag != tagToCollideWith)
			return;

		unityEvent.Invoke();
	}
}
