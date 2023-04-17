using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver = false;
    public bool isOnGround = true;
    public float jumpForce = 10.0f;
    public float gravityModifier;
    private bool doubleJump = false;
    public float doubleJumpForce;
    public bool doubleSpeed = false;

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

            doubleJump = false;
        }else if(Input.GetKeyDown(KeyCode.Space) && !isOnGround  && !doubleJump)
        {
            playerRb.AddForce(Vector3.up * doubleJumpForce, ForceMode.Impulse);
            playerAnim.SetTrigger("Jump_trig");
            playerAudioSource.PlayOneShot(jumpSound, 1.0f);
            doubleJump = true;
            doubleJump = true;

        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            doubleSpeed = true;
            playerAnim.SetFloat("SpeedMultipier", 2.0f);
        }else if (doubleSpeed)
        {
            doubleSpeed = false;
            playerAnim.SetFloat("SpeedMultipier", 1.0f);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !gameOver)
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
