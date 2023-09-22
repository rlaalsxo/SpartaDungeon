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
        attack.text = "���ݷ� : " + itemstat.attack.ToString();
        def.text = "���� : " + itemstat.def.ToString();
        hp.text = "ü�� : " + itemstat.hp.ToString();
        if (itemstat.eq)
        {
            eq.text = "��������";
        }
        else
        {
            eq.text = "����";
        }
    }
    public void Eq()
    {
        if(eq.text == "����")
        {
            itemstat.eq = true;
            PlayerManager.Instance.Eqitem[itemstat.type] = itemstat;
            GameManager.Instance.player.CurrentStats.attack += itemstat.attack;
            GameManager.Instance.player.CurrentStats.def += itemstat.def;
            GameManager.Instance.player.CurrentStats.maxHealth += itemstat.hp;
        }
        else if(eq.text == "��������")
        {
            itemstat.eq = false;
            PlayerManager.Instance.Eqitem[itemstat.type] = null;
            GameManager.Instance.player.CurrentStats.attack -= itemstat.attack;
            GameManager.Instance.player.CurrentStats.def -= itemstat.def;
            GameManager.Instance.player.CurrentStats.maxHealth -= itemstat.hp;
        }
    }
}
