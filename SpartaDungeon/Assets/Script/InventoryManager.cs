using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    List<Item> items;
    [SerializeField] Image inventory;
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
}
