using NUnit.Framework.Constraints;
using UnityEngine;

public class pickableitem : MonoBehaviour
{
    [SerializeField]
    private item itemobject;
    private SpriteRenderer spriteR;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteR.sprite = itemobject.item_image;
    }
}
