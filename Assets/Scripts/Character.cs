using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu()]
public class Character : ScriptableObject
{
    public string Name;
    //public Sprite Sprite;
    public Manager.Tags[] TagsObject;
}