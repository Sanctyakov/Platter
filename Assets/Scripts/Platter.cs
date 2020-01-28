using UnityEngine;

public class Platter : MonoBehaviour //Controls the platter -the platform on which the ball rolls.
{
	public float speed; //Set within the inspector.
	public float maxIncline; //The maximum angle the platform will reach in any direction.
	public Rigidbody rb; //Reference set in inspector.
	public Boundary boundary; //A set of boundaries for the platform's rotation.

	void FixedUpdate()
	{
		float rotateZAxis = Input.GetAxis("Horizontal"); //Rotate around the Z axis in the left / right direction.
		float rotateXAxis = Input.GetAxis("Vertical"); //Rotate around the X axis in the up / down direction.

		Vector3 movement = new Vector3(rotateXAxis, 0.0f, -rotateZAxis); //Rotation is not inverted.

		rb.rotation = Quaternion.RotateTowards(rb.rotation, Quaternion.Euler(movement * maxIncline), speed * Time.fixedDeltaTime);
	}
}