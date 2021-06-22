using UnityEngine;

public class MoveWithInput : MonoBehaviour
{
	public float speed = 5f;

	public KeyCode leftButton = KeyCode.A;
	public KeyCode rightButton = KeyCode.D;
	public KeyCode upButton = KeyCode.W;
	public KeyCode downButton = KeyCode.S;

	public bool moveRelativeToRotation = false;

	Space mode;

	void Update()
    {
		float amount = speed * Time.deltaTime;

		if (moveRelativeToRotation == true)
			mode = Space.Self;
		else
			mode = Space.World;

		if (Input.GetKey(leftButton)) {
			transform.Translate(-amount, 0f, 0f, mode);
			transform.eulerAngles = new Vector2(0, 180);
		}

		if (Input.GetKey(rightButton)) {
			transform.Translate(amount, 0f, 0f, mode);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetKey(upButton))
			transform.Translate(0f, amount, 0f, mode);

		if (Input.GetKey(downButton))
			transform.Translate(0f, -amount, 0f, mode);
	}
}
