using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float ObstacleSpeed = 15f;

    private PlayerController playerControllerScript;
    private int LeftBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerControllerScript.GameOver)
        {
            transform.Translate(Vector3.left * ObstacleSpeed * Time.deltaTime);
        }

        if (transform.position.x < LeftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
