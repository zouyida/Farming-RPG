using UnityEngine;

public class Item : MonoBehaviour
{
    [ItemCodeDescription]
    [SerializeField]
    private int itemCode;

    private SpriteRenderer spriteRenderer;

    public int ItemCode { get { return itemCode; } set {  itemCode = value; } }

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        if (ItemCode != 0)
        {
            Init(ItemCode);
        }
    }

    public void Init(int itemCodeParam)
    {
        ItemCode = itemCodeParam;

        ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(ItemCode);

        spriteRenderer.sprite = itemDetails.itemSprite;
        if (itemDetails.itemType == ItemType.ReapableScenary)
        {
            gameObject.AddComponent<ItemNudge>();
        }
    }

}
