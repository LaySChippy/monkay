using Unity.VisualScripting;
using UnityEngine;

public class Genericenemy : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float health;
    [SerializeField] private float attackdmg;
    [SerializeField] private float attackspd;
    [SerializeField] private int max_detection_range;
    [SerializeField] private string target_tag;

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

    void FindClosest(){
        GameObject[] player = GameObject.FindGameObjectsWithTag(target_tag);
        GameObject closest_enemy=null;
        float closest_distance = Mathf.Infinity;
    }
    
}
