using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour, IPointerDownHandler
{
    List<Item> items;
    [SerializeField] Image inventory;
    [SerializeField] EqManager ItemWindow;
    void Start()
    {
        items = PlayerManager.Instance.items;
        if(items.Count > 0)
        {
            for(int i = 0; i < items.Count; i++)
            {
                Image image = Resources.Load<Image>("Item/" + items[i].name);
                Image item = Instantiate(image, inventory.transform, false);
                item.name = image.name;
            }
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.pointerEnter.tag == "Item")
        {
            Item item = eventData.pointerEnter.gameObject.GetComponent<Item>();
            if (ItemWindow.gameObject.activeSelf == false && UIManager.Instance.Inventory.gameObject.activeSelf == true)
            {
                ItemWindow.gameObject.SetActive(true);
                ItemWindow.itemstat = item;
                ItemWindow.Status();
            }
        }
    }
}
