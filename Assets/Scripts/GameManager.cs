using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour //Controls the game flow and UI.
{
    public Text countText;

    public Text winText; //Displayed when you win the level.

    public GameObject[] pickUps; //Each level will have a different amount of pick ups.

    [HideInInspector]
    public int count; //Pick ups collected. Hidden in the editor.

    void Start()
    {
        Control.SetGameManager(this); //Provides the reference to this script to the Control static class.

        count = 0;

        UpdateText();

        winText.text = "";
    }

    public void UpdateText()
    {
        countText.text = "Count: " + count;

        if (count >= pickUps.Length) //Displays when all pick ups have been collected.
        {
            winText.text = "You win!";
        }
    }
}
