using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public static StatusManager Instance;
    [SerializeField] TextMeshProUGUI attacktxt;
    [SerializeField] TextMeshProUGUI deftxt;
    [SerializeField] TextMeshProUGUI hptxt;
    [SerializeField] TextMeshProUGUI level;
    [SerializeField] Image exp;
    private void Awake()
    {
        Instance= this;
    }
    public void StatusUpdate()
    {
        level.text = "Lv. " + GameManager.Instance.player.CurrentStats.level.ToString();
        attacktxt.text = GameManager.Instance.player.CurrentStats.attack.ToString();
        deftxt.text = GameManager.Instance.player.CurrentStats.def.ToString("N1");
        hptxt.text = GameManager.Instance.player.CurrentStats.maxHealth.ToString();
        exp.fillAmount = ((int)GameManager.Instance.player.CurrentStats.exp / (GameManager.Instance.player.CurrentStats.level * 100));
    }
}
