using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // Destroys animals and food on collision
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
