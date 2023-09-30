using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DetectsCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Increases score when animals hit 
        PlayerController.score++;
        Debug.Log("Score : " + PlayerController.score);

        // Destroys animals and food on collision
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
