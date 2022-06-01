using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator PlayerAnim;
    private bool IsOnGround = true;
    private AudioSource PlayerAudio;
    public float gravityModifier;
    public float jumpForce;   
    public bool GameOver;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip crashSound;
    public AudioClip jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAudio = GetComponent<AudioSource>();
        PlayerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (IsOnGround) && GameOver == false) 
        {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            IsOnGround = false;
            PlayerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            PlayerAudio.PlayOneShot(jumpSound,1.0f);
        }



    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            IsOnGround = true;
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            PlayerAnim.SetBool("Death_b", true);
            PlayerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            Debug.Log("Game Over!");
            GameOver = true;
            PlayerAudio.PlayOneShot(crashSound, 1.0f);


        }
    }
}
