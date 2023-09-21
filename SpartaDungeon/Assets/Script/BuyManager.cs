using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyManager : MonoBehaviour
{
    public ItemStat itemstat;
    [SerializeField] Image sprite;
    [SerializeField] TextMeshProUGUI attack;
    [SerializeField] TextMeshProUGUI def;
    [SerializeField] TextMeshProUGUI hp;
    [SerializeField] TextMeshProUGUI weaponName;
    [SerializeField] TextMeshProUGUI price;
    public void Status()
    {
        sprite.sprite = itemstat.gameObject.GetComponent<Image>().sprite;
        weaponName.text = itemstat.gameObject.name;
        attack.text = "공격력 : " + itemstat.Attack.ToString();
        def.text = "방어력 : " + itemstat.Def.ToString();
        hp.text = "체력 : " + itemstat.Hp.ToString();
        price.text = itemstat.gold.ToString();
    }
    public void Buy()
    {
        if(GameManager.Instance.player.CurrentStats.gold >= itemstat.gold)
        {
            if(itemstat.Type == 0)
            {
                PlayerManager.Instance.items.Add(new Weapon(itemstat.name, itemstat.Attack, itemstat.Hp, itemstat.Def));
            }
            else if (itemstat.Type == 1)
            {
                PlayerManager.Instance.items.Add(new Armor(itemstat.name, itemstat.Attack, itemstat.Hp, itemstat.Def));
            }
            GameManager.Instance.player.CurrentStats.gold -= itemstat.gold;
            StatusManager.Instance.GoldUpdate();
        }
    }
}
