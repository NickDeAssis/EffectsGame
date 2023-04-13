using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver = false;
    public bool isOnGround = true;
    public float jumpForce = 10.0f;
    public float gravityModifier;
    public ParticleSystem explostionParticle;
    public ParticleSystem dirtParticle;
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudioSource;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
        //playerRb.AddForce(Vector3.up * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            dirtParticle.Stop();
            playerAudioSource.PlayOneShot(jumpSound, 1.0f);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            dirtParticle.Play();
            isOnGround = true;
        }else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explostionParticle.Play();
            dirtParticle.Stop();
            playerAudioSource.PlayOneShot(crashSound, 1.0f);
            Debug.Log("Game Over!");
        }

    }

}
