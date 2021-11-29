using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string PlayerName = "";

    public int HighScore = 0;

    const string _fileName = "/savefile.json";

    class Data
    {
        public int HighScore;
    }


    private void Awake()
    {
        if(GameManager.Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadData();
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetPlayerName(string playerName)
    {
        PlayerName = playerName;
    }
         
    public void SaveData()
    {
        Data data = new Data();
        data.HighScore = HighScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + _fileName, json);
        Debug.Log("saved");

        LoadData();
        
    }

    public void LoadData()
    {
        if(File.Exists(Application.persistentDataPath + _fileName))
        {
            string json = File.ReadAllText(Application.persistentDataPath + _fileName);
            Data data = JsonUtility.FromJson<Data>(json);

            HighScore = data.HighScore;

            Debug.Log(JsonUtility.FromJson<Data>(json).HighScore);
        }
    }
}
