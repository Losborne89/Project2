using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds: MonoBehaviour
{
    private float topBound = 40f;
    private float lowerBound = -10f;


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

        // destroys animals when out of bounds 
        if (transform.position.z < lowerBound)
        {
            // Reduce lives
            PlayerController.lives--;
            Debug.Log("Lives : " + PlayerController.lives);

            if (PlayerController.lives < 0)
            {
                // Prints 'Game Over!'
                Debug.Log("Game Over!");
            }

            Destroy(gameObject);
        }
    }
}
