using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public float HorizontalInput;
    private float PlayerSpeed = 10f;
    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-20 )
        {
            transform.position=new Vector3(-20,transform.position.y,transform.position.z);
        }
        if ( transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }


        HorizontalInput = Input.GetAxis("Horizontal");
      
        transform.Translate(Vector3.right*PlayerSpeed*HorizontalInput*Time.deltaTime);
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
    
}
