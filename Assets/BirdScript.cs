using UnityEngine;


public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;


    void Start()
    {
        // Optional: You can initialize or log something here if needed
        myRigidbody.freezeRotation = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.linearVelocity = Vector2.up * 10;
        }
        
       
    }
}

