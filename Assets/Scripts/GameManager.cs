using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // can access from any other script
                                         // values stored in this class member will be shared by all the instances of that class


    public string playerName;
    public int highScore;
    public string playerNameHighScore;
    public int highScoreHighScore;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }

    [System.Serializable]
    class SaveData

    {
        public string playerName; // le nom du joueur
        public int highScore;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.highScore = highScore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerNameHighScore = data.playerName;
            highScoreHighScore = data.highScore;
            
        }

       
    }


}
