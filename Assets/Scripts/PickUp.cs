using UnityEngine;

public class PickUp : MonoBehaviour
{
	void Update ()
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime); //Pick ups rotate.
	}
}
