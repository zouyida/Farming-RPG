using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    public int itemCode;
    public ItemType itemType;
    public Sprite itemSprite;
    public string itemDescription;
    public string itemLongDescription;
    public short itemUseGridRadius;
    public float itemUseRadius;
    public bool isStartingItem;
    public bool isPickable;
    public bool isDroppable;
    public bool isEatable;
    public bool isPortable;
}
