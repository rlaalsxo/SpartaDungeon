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
                Image item = Instantiate(Resources.Load<Image>("Item/" + items[i].name), inventory.transform, false);
            }
        }
    }
}
