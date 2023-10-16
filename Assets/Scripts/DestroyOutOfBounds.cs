using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds: MonoBehaviour
{
    private float topBound = 40f;
    private float lowerBound = -10f;
    private float rightBound = 30f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // destroys spear when out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }

        // destroys animals when out of lowerbound and rightbound
        if (transform.position.z < lowerBound)
        {
            // Reduces lives when animal gets past the player
            PlayerController.lives--;
            Debug.Log("Lives : " + PlayerController.lives);

            
            if (PlayerController.lives < 0)
            {
                // Prints 'Game Over!' when lives are less than 0
                Debug.Log("Game Over!");
            }

            Destroy(gameObject);
        }
    }
}
