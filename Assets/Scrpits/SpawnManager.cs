using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    //opposing= ops
    private float opsSpawnRangeX = 20;
    private float opsSpawnPosZ = 40;
    //left
    private float leftSpawnPosX = -24;
    private float leftSpawnRangeZ = 10;
    //right
    private float rightSpawnPosX = 22;
    private float rightSpawnRangeZ = 10;

    private float startDelay=2;
    private float spawnInterval = 1.5f;
    private int difficulty = 0;

    // Start is called before the first frame update
    void Invoke()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnEnemyStart()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval); //Auto Spawn Enemy 
    }
    public void GetDifficulty(int getdifficulty)
    {
        difficulty = getdifficulty;
    }
    public void SpawnRandomEnemy() 
    {
        int enemyIndex = Random.Range(0, EnemyPrefabs.Length); //Select Random Enemy
        //opposing=ops
        Vector3 spawnPosX = new Vector3(Random.Range(-opsSpawnRangeX, opsSpawnRangeX), 0, opsSpawnPosZ); //Select Random Pos 
        //right
        Vector3 rightSpawnPosZ = new Vector3(rightSpawnPosX, 0, Random.Range(-rightSpawnRangeZ, rightSpawnRangeZ)); //Select Random Pos
        //left
        Vector3 leftSpawnPosZ = new Vector3(leftSpawnPosX,0, Random.Range(-leftSpawnRangeZ, leftSpawnRangeZ)); //Select Random Pos
        if (difficulty == 1) {
            //opposing=ops
            
            Instantiate(EnemyPrefabs[enemyIndex], spawnPosX, EnemyPrefabs[enemyIndex].transform.rotation); // Spawn oppesing Enemy


        }
        if (difficulty == 2) {

            Instantiate(EnemyPrefabs[enemyIndex], spawnPosX, EnemyPrefabs[enemyIndex].transform.rotation); // Spawn oppesing Enemy
            Instantiate(EnemyPrefabs[enemyIndex], rightSpawnPosZ, EnemyPrefabs[enemyIndex].transform.rotation * Quaternion.Euler(0, 90, 0));  //sağdangelen

        }
        if (difficulty == 3) {
            Instantiate(EnemyPrefabs[enemyIndex], spawnPosX, EnemyPrefabs[enemyIndex].transform.rotation); // Spawn oppesing Enemy
            Instantiate(EnemyPrefabs[enemyIndex], rightSpawnPosZ, EnemyPrefabs[enemyIndex].transform.rotation * Quaternion.Euler(0, 90, 0));  //sağdangelen
            Instantiate(EnemyPrefabs[enemyIndex], leftSpawnPosZ, EnemyPrefabs[enemyIndex].transform.rotation * Quaternion.Euler(0, -90, 0)); //soldan gelen
        }
        
        //opposing=ops
        //Vector3 spawnPosX = new Vector3(Random.Range(-opsSpawnRangeX, opsSpawnRangeX), 0, opsSpawnPosZ); //Select Random Pos
        //Instantiate(EnemyPrefabs[enemyIndex], spawnPosX, EnemyPrefabs[enemyIndex].transform.rotation); // Spawn oppesing Enemy

        ////right
        //Vector3 rightSpawnPosZ = new Vector3(rightSpawnPosX, 0, Random.Range(-rightSpawnRangeZ, rightSpawnRangeZ)); //Select Random Pos
        //Instantiate(EnemyPrefabs[enemyIndex], rightSpawnPosZ, EnemyPrefabs[enemyIndex].transform.rotation*Quaternion.Euler(0,90,0));  //sağdangelen

        ////left
        //Vector3 leftSpawnPosZ = new Vector3(leftSpawnPosX,0, Random.Range(-leftSpawnRangeZ, leftSpawnRangeZ)); //Select Random Pos
        //Instantiate(EnemyPrefabs[enemyIndex], leftSpawnPosZ, EnemyPrefabs[enemyIndex].transform.rotation * Quaternion.Euler(0, -90, 0)); //soldan gelen

    }
}
