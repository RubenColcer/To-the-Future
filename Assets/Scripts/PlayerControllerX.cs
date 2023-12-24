using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizonalInput;
    private Rigidbody playerRb;

     public ParticleSystem explosionParticle;
     private AudioSource playerAudio;
     public AudioClip explodeSound;
     
    // Start is called before the first frame update
    void Start()
    {
    //fetches the Rigidbody component from the GameObject and sets to variable playerRb
    playerRb = GetComponent<Rigidbody>();
    //fetches the AudioSource component and sets to variable playerAudio
    playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical"); // up down
        horizonalInput = Input.GetAxis("Horizontal"); //left and right

         transform.Translate(Vector3.down * speed * horizonalInput * Time.deltaTime );
        transform.Rotate (Vector3.left * Time.deltaTime * verticalInput * rotationSpeed );
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with Rock, runs the explode particle and should of ran an explosion noise but unable to fix
        if (other.gameObject.CompareTag("Rock"))
        {
            
            explosionParticle.Play();
            //playerAudio.PlayOneShot(explodeSound, 1.0f);
            
            Destroy(other.gameObject);
           // if Touched rock would take to to GameOver scene
            //SceneManager.LoadScene("GameOver");
            
        } 
            // If player hits diamond takes you to Survuved scene
        else if (other.gameObject.CompareTag("Diamond"))
        {
            
            
            
            Destroy(other.gameObject);
           
            SceneManager.LoadScene("Survived");
            
        } 
    }
}
