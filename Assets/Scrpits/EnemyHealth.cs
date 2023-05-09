using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public static EnemyHealth instance;
    
    public float health;
    public float maxHealth;

    public GameObject healthBarUI;
    public Slider slider;
    private GameController gameController;
    
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = maxHealth;

        health = maxHealth;
        //gameController = GameObject.Find("GameManager").GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        health += damage;
        slider.value = health;
        Debug.Log("Enemy Health: " + slider.value);
        
        if (slider.value <= 0) 
        {
            Destroy(gameObject);
            GameController.instance.EnemyKilled();
        }
    }
}
