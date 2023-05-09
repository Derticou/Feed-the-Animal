using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    

    [SerializeField]
    public GameObject UI;
    public Text killcounter, lives;
    public Button restart, exit;
    public GameObject mainMenu;
    public GameObject selectDifficulty;
    public GameObject titleScreen;

    private int enemyKillCount;
    private int live = 3;

    void Start()
    {
        UI.SetActive(false);
    }
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }
    public void StartGame() 
    {
        
    }
    public void EnemyKilled()
    {
        enemyKillCount++;
        killcounter.text = "" + enemyKillCount;
    }
    public void Lives()
    {
        live--;
        lives.text = "" + live;
        if (live <= 0) { GameOver(); }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        UI.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    { 
        UI.SetActive(true);
        Time.timeScale = 0;
    }
    public void SelectDifficulty()
    {
        mainMenu.SetActive(false);
        selectDifficulty.SetActive(true);
    }
}
