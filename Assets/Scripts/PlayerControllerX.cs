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
    playerRb = GetComponent<Rigidbody>();
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
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Rock"))
        {
            
            explosionParticle.Play();
            //playerAudio.PlayOneShot(explodeSound, 1.0f);
            
            Destroy(other.gameObject);
           
            //SceneManager.LoadScene("GameOver");
            
        } 
    }
}
