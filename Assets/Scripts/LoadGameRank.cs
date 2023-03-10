using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class LoadGameRank : MonoBehaviour


{
    //field to display player info
    public Text BestPlayerName;

    //static variables for holding the best plauyer data
    private static int BestScore;
    private static string BestPlayer;

    private void Awake()
    {
        LoadGameRanks();
    }

    private void SetBestPlayer()
    {
        if (BestPlayer == null && BestScore == 0)
        {
            BestPlayerName.text = "";
        }
        else
        {
            BestPlayerName.text = $"Best Score - {BestPlayer}: {BestScore}";
        }
    }

    public void LoadGameRanks()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            BestPlayer = data.TheBestPlayer;
            BestScore = data.TheHighestScore;
            SetBestPlayer();
        }
    }

    [System.Serializable]
    class SaveData
    {
        public int TheHighestScore;
        public string TheBestPlayer;
    }

    
}
