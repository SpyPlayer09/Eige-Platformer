
public class GameData
{
    private static GameData instance;

    private GameData()
    {
        if (instance != null)
            return;
        instance = this;
    }

    public static GameData Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameData();
            }
            return instance;
        }
    }
    
    private int score = 0;
    public int Score
    {
        get => score; //Gleich wie {return score}
        set => score = value; //=> entspricht der Einklammerung eines Statements
    }
    public int Lives
    {
        get; //Automatische Implementierung durch C#
        set;
    }
}
