using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();

        if (item != null )
        {
            ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(item.ItemCode);

            if (itemDetails.isPickable == true)
            {
                InventoryManager.Instance.AddItem(InventoryLocation.Player, item, collision.gameObject);
            }
        }
    }
}
