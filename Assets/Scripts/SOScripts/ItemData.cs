using UnityEngine;

public enum ItemType
{
    Bow,
    Axe,
    Sword,
    Scroll
}

[CreateAssetMenu(fileName = "New itemData", menuName = "Item Data", order = 51)]
public class ItemData : ScriptableObject
{
    public string itemName;
    public ItemType type;
    public float attack;

    public Sprite icon;

    public float GetPrice()
    {
        return attack * 40;
    }
}