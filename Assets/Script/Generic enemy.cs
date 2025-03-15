using UnityEngine;

public class Genericenemy : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float health;
    [SerializeField] private float attackdmg;
    [SerializeField] private float attackspd;
    [SerializeField] private int max_detection_range;
    [SerializeField] private string target_tag;

    private Rigidbody2D rb;

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

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    void Update()
    {
        FindClosest();
    }

    void FindClosest(){
        GameObject player = GameObject.FindGameObjectWithTag(target_tag);
        float dist = Vector2.Distance(player.transform.position, transform.position);
        if (dist<max_detection_range){
            var x = Vector2.MoveTowards(transform.position, player.transform.position, movespeed*Time.deltaTime);
            rb.MovePosition(x);
        }
    }
    
}
