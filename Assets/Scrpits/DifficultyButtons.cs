using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtons : MonoBehaviour
{
    private Button button;
    private SpawnManager spawnManager;
    public GameObject TitleScreen;

    public int difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnManager=GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        button=GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    private void SetDifficulty()
    {
        TitleScreen.SetActive(false);
        spawnManager.GetDifficulty(difficulty);
        spawnManager.SpawnEnemyStart();
    }
}
