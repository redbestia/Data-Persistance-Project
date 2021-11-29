using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScoreShower : MonoBehaviour
{
    [SerializeField] string _textBeforeName = "High Score";
    int _highScore = 0;
    string _playerName = "NoName";

    public void SetHighScoreText()
    {
        if (GameManager.Instance == null)
        {
            setHighScoreText();
            Debug.LogWarning("ScenaMenage.Instance == null");
        }
        else
        {
            _highScore = GameManager.Instance.HighScore;
            _playerName = GameManager.Instance.PlayerName;
            setHighScoreText();
        }
    }

    private void Start()
    {
        SetHighScoreText();
    }

    private void setHighScoreText()
    {
        GetComponent<Text>().text = _textBeforeName + ": " + _playerName + ": " + _highScore;
    }
}
