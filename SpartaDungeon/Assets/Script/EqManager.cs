using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EqManager : MonoBehaviour
{
    public Item itemstat;
    [SerializeField] Image sprite;
    [SerializeField] TextMeshProUGUI attack;
    [SerializeField] TextMeshProUGUI def;
    [SerializeField] TextMeshProUGUI hp;
    [SerializeField] TextMeshProUGUI weaponName;
    [SerializeField] TextMeshProUGUI eq;
    public void Status()
    {
        sprite.sprite = itemstat.gameObject.GetComponent<Image>().sprite;
        weaponName.text = itemstat.gameObject.name;
        attack.text = "°ø°Ý·Â : " + itemstat.attack.ToString();
        def.text = "¹æ¾î·Â : " + itemstat.def.ToString();
        hp.text = "Ã¼·Â : " + itemstat.hp.ToString();
        if (itemstat.eq)
        {
            eq.text = "ÀåÂøÇØÁ¦";
        }
        else
        {
            eq.text = "ÀåÂø";
        }
    }
    public void Eq()
    {
        if(eq.text == "ÀåÂø")
        {
            itemstat.eq = true;
            PlayerManager.Instance.Eqitem[itemstat.type] = itemstat;
            GameManager.Instance.player.CurrentStats.attack += itemstat.attack;
            GameManager.Instance.player.CurrentStats.def += itemstat.def;
            GameManager.Instance.player.CurrentStats.maxHealth += itemstat.hp;
        }
        else if(eq.text == "ÀåÂøÇØÁ¦")
        {
            itemstat.eq = false;
            PlayerManager.Instance.Eqitem[itemstat.type] = null;
            GameManager.Instance.player.CurrentStats.attack -= itemstat.attack;
            GameManager.Instance.player.CurrentStats.def -= itemstat.def;
            GameManager.Instance.player.CurrentStats.maxHealth -= itemstat.hp;
        }
    }
}
