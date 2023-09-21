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
    private void Awake()
    {
        Instance= this;
    }
    public void StatusUpdate()
    {
        attacktxt.text = GameManager.Instance.player.CurrentStats.attack.ToString();
        deftxt.text = GameManager.Instance.player.CurrentStats.def.ToString("N1");
        hptxt.text = GameManager.Instance.player.CurrentStats.maxHealth.ToString();
    }
}
