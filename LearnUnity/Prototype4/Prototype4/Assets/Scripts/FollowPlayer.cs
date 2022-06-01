using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public Vector3 CameraPosition1 = new Vector3(0, 5, -7);
    public Vector3 CameraPosition2 = new Vector3(0, 1.78f, 1.38f);
    public int sayac=0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (sayac % 2 == 0)
        {
            transform.position = Player.transform.position + CameraPosition2;
        }

        if (sayac % 2 !=0)
        {
            transform.position = Player.transform.position + CameraPosition1;
        }
      
        if (Input.GetKeyUp(KeyCode.V))
        {
            sayac = sayac + 1;          
        }

       

        
            
        
       
    }
}
