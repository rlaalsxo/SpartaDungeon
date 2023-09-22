using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopManager : MonoBehaviour, IPointerDownHandler
{
    List<Image> items;
    [SerializeField] Image Shop;
    [SerializeField] BuyManager BuyWindow;
    void Start()
    {
        items = Resources.LoadAll<Image>("Item/").ToList();
        if (items.Count > 0)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Image item = Instantiate(items[i], Shop.transform, false);
                item.name = items[i].name;
            }
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if(eventData.pointerEnter.tag == "Item")
        {
            ItemStat item = eventData.pointerEnter.gameObject.GetComponent<ItemStat>();
            if(BuyWindow.gameObject.activeSelf == false && UIManager.Instance.Shop.gameObject.activeSelf == true)
            {
                BuyWindow.gameObject.SetActive(true);
                BuyWindow.itemstat = item;
                BuyWindow.Status();
            }
        }
    }
}
