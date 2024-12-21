using UnityEditor.Build;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "Scriptable Objects/item")]
public class item : ScriptableObject
{
    public string item_name;
    public Sprite item_sprite;
}
