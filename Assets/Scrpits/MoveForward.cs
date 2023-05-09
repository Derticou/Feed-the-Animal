using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    public float rotateSpeed = 140.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
      //  transform.Rotate(Vector2.up * Time.deltaTime * rotateSpeed);

    }
}
