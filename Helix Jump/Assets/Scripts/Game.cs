using System;
using UnityEngine;
using UnityEngine.SceneManagement;
//состояние игры (процесс / победа / поражение)
public class Game : MonoBehaviour
{
    public Controls Controls;
    public static int scores; // очки
    public static int scoresBest; // рекорд

    public GameObject LoseScene;
    public GameObject WinScene;

    public static int Record()
    {
        if (scores > scoresBest)
        {
            scoresBest = scores;
            return scores;
        }
        else
        {
            return scoresBest;
        }
        
    }
    public enum State
    {
        Plaing,
        Won,
        Lose,
    }
    
    public State CurrentState{get; private set; }

    public void Restart()
    {
        LoseScene.SetActive(false);
        ReloadLevel();
    }
    
    // игрок проиграл
    public void OnPlayerDied()
    {
        
        if (CurrentState != State.Plaing) return;
        LoseScene.SetActive(true);
        CurrentState = State.Lose;
        Controls.enabled = false;
        Debug.Log("Game Over!");
        scores = 0;
        //ReloadLevel();
    }

    private void Start()
    {
        scoresBest = PlayerPrefs.GetInt("scoresBest");

    }
    public void Continuous()
    {
        
        WinScene.SetActive(false);
        ReloadLevel();
    }
    public void OnPlayerReachedFinish()
    {
        
        if(CurrentState != State.Plaing) return;
        WinScene.SetActive(true);
        CurrentState = State.Won;
        Controls.enabled = false;
        LevelIndex++;        
        Debug.Log("You won!");
        //ReloadLevel();
    }
    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey,value);
            PlayerPrefs.Save();
        }
        
    }
    private const string LevelIndexKey = "LevelIndex";

   
    private void ReloadLevel()
    {   
        PlayerPrefs.SetInt("scoresBest", scoresBest);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
