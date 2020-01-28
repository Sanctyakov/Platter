using UnityEngine;

public class Ball : MonoBehaviour //Checks collisions with pick ups.
{
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			Destroy(other.gameObject);
			Control.Count++;
			Control.UpdateText();
		}
	}
}