using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Image Exp;
    public Image Status;
    public Image Inventory;
    public Image Shop;
    private void Awake()
    {
        Instance = this;
        StatusManager.Instance.StatusUpdate();
    }
    public void OpenStatus()
    {
        if(Status.gameObject.activeSelf)
        {
            Status.gameObject.SetActive(false);
        }
        else
        {
            Status.gameObject.SetActive(true);
        }
    }
    public void OpenInven()
    {
        if (Inventory.gameObject.activeSelf)
        {
            Inventory.gameObject.SetActive(false);
        }
        else
        {
            Inventory.gameObject.SetActive(true);
        }
    }
    public void OpenShop()
    {
        if (Shop.gameObject.activeSelf)
        {
            Shop.gameObject.SetActive(false);
        }
        else
        {
            Shop.gameObject.SetActive(true);
        }
    }
}
