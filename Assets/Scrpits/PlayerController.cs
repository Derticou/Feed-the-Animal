using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 30;
    private float xRange = 23;
    private float zRangeUp = 20;
    private float zRangeDown = -16;
    

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input player move
        horizontalInput = Input.GetAxis("Horizontal"); 
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); // Player move left or right
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
       
        //Bounds
        if (transform.position.x<-xRange) { transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); } // Left 
        if (transform.position.x> xRange) { transform.position = new Vector3( xRange, transform.position.y, transform.position.z); } // Right 
        if(transform.position.z<zRangeDown) { transform.position = new Vector3(transform.position.x,transform.position.y, zRangeDown); } //down
        if (transform.position.z > zRangeUp) { transform.position = new Vector3(transform.position.x, transform.position.y, zRangeUp); } //up

        if (Input.GetKeyDown(KeyCode.Space)) //If press Space
        {
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation); //spawn Projectile
        }

    }
}
