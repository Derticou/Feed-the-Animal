using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBounds : MonoBehaviour
{


    private float topBound = 45;
    private float lowerBound = -20;

    private float leftBound = -25;
    private float rightBound = 25;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z>topBound)  //Top bound
        {
            Destroy(gameObject);
        }
        if (transform.position.z<lowerBound) //Lower Bound
        {
            
            Destroy(gameObject);
            GameController.instance.Lives();

        }
        if (transform.position.x<leftBound)
        {
            Destroy(gameObject);
            GameController.instance.Lives();

        }
        if (transform.position.x>rightBound)
        {
            Destroy(gameObject);
            
            GameController.instance.Lives();
        }
    }
}
