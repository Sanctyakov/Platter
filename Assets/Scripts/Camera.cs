using UnityEngine;

public class Camera : MonoBehaviour //A script that follows the ball around.
{
	public GameObject ball; //Reference set in inspector.

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - ball.transform.position; //The camera remains at the same distance from the player as it was from start.
	}
	
	void Update ()
	{
		transform.position = ball.transform.position + offset;
	}
}
