using UnityEngine;

public class weaponhandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private GameObject player;
    private int facing = 0;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            facing = 3;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            facing = 1;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            facing = 2;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            facing = 0;
        }

        transform.rotation = new Quaternion(0, 0, (90 * facing)+90,);


    }
}
