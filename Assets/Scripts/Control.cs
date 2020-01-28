public static class Control //A static class that communicates game objects with the Game Manager script.
{
    private static GameManager gM;

    public static void SetGameManager (GameManager gameManager) //Sets the reference to the Game Manager script.
    {
        gM = gameManager;
    }

    public static int Count
    {
        get { return gM.count; }
        set { gM.count = value; }
    }

    public static void UpdateText()
    {
        gM.UpdateText();
    }
}
