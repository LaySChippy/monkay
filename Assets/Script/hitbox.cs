using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class hitbox : MonoBehaviour
{

    [SerializeField] private float hitCooldown = 1f;


    // Update is called once per frame
    void Update()
    {
        hitCooldown -= Time.deltaTime;
        if (hitCooldown <= 0)
        {
            Destroy(gameObject);
        }
    }
}
