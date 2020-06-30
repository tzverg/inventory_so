using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemData[] inventory;
    int index = 0;

    public void NextItemInfo()
    {
        if (index >= inventory.Length)
        {
            index = 0;
        }

        Debug.Log("Item name: " + inventory[index].itemName);
        Debug.Log("Attack power: " + inventory[index].attack);
        Debug.Log("Item type: " + inventory[index].type.ToString());
        Debug.Log("Item price: " + inventory[index].GetPrice());

        index++;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextItemInfo();
        }
    }
}
