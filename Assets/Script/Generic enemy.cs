using UnityEngine;

public class Genericenemy : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float health;
    [SerializeField] private float attackdmg;
    [SerializeField] private float attackspd;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerHitbox"))
        {
            health -= 1f;
            if (health < 1f)
            {
                Destroy(gameObject);
            }
        }
    }
    
}
