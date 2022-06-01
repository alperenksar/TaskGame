using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private GameManager gameManager;
    private float maxTorque = 10f;
    private float MaxSpeed = 16f;
    private float MinSpeed = 12f;
    private float xRange = 4f;
    private Rigidbody targetRb;
    public int PointValue;
    public ParticleSystem explosionParticle;
  


    // Start is called before the first frame update
    void Start()
    {
        
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        targetRb.AddForce(RandomForce(),ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-xRange, xRange), -2, 0);
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(gameManager.gameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.UpdateScore(PointValue);
        }
      
           
        

        
      
        
    }
    private void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);


        if (gameObject.CompareTag("GoodObject")) 
        {          
            gameManager.Gameover();
        }
        
        
    }
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(MinSpeed, MaxSpeed);
    }
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
}
