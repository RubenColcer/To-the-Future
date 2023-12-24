using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //make a variable called Player from GameObject
    public GameObject Player;
    //Moves on this axis in certain unitys
    private Vector3 offset =new Vector3(200, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Makes the camera move
        transform.position = Player.transform.position + offset;
    }
}
