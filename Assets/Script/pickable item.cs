using UnityEngine;

public class pickableitem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D (Collision2D other)
    {
        Destroy(gameObject);
    }
}
