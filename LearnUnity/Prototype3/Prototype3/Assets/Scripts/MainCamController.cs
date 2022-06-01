using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamController : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public AudioSource MainCamAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        MainCamAudio.Play(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.GameOver)
        {
            MainCamAudio.Stop();
            //stop
        }
        

        

    }
}
