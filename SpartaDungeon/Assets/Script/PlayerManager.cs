using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    public List<Item> items;
    public Item[] Eqitem = new Item[2];
    private void Awake()
    {
        Instance = this;
        items = new List<Item>();
        items.Add(new Weapon("�׳� ��", 5, 0, 1, false));
        items.Add(new Armor("�׳� ����", 1, 10, 2, false));
    }
}
