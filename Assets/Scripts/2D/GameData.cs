public class GameData {
    private static GameData instance;

    private GameData() {
        if (instance != null)   {
            return;
        }
        instance = this;
    }

    public static GameData Instance {
        get {   //Getter Function. Same goes for set -> Setter | Quicker Method
            if (instance == null)   {
                new GameData();
            }
            return Instance;
        }
    }

    private int score = 0;

    public int Score {
        get {
            return score;
        }
        set {
            score = value;
        }
    }

    public int Lives {
        get;
        set;
    }
}