using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Image ButtonUI;
    public Image Status;
    public Image Inventory;
    public Image Shop;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        StatusManager.Instance.StatusUpdate();
    }
    public void OpenStatus()
    {
        if(Status.gameObject.activeSelf)
        {
            Status.gameObject.SetActive(false);
            ButtonUI.gameObject.SetActive(true);
        }
        else
        {
            Status.gameObject.SetActive(true);
            ButtonUI.gameObject.SetActive(false);
        }
    }
    public void OpenInven()
    {
        if (Inventory.gameObject.activeSelf)
        {
            Inventory.gameObject.SetActive(false);
            ButtonUI.gameObject.SetActive(true);
        }
        else
        {
            Inventory.gameObject.SetActive(true);
            ButtonUI.gameObject.SetActive(false);
        }
    }
    public void OpenShop()
    {
        if (Shop.gameObject.activeSelf)
        {
            Shop.gameObject.SetActive(false);
            ButtonUI.gameObject.SetActive(true);
        }
        else
        {
            Shop.gameObject.SetActive(true);
            ButtonUI.gameObject.SetActive(false);
        }
    }
}
