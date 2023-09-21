using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    public List<Item> items;
    private void Awake()
    {
        Instance = this;
        items = new List<Item>();
        items.Add(new Weapon("�׳� ��", 5, 0, 1));
        items.Add(new Armor("�׳� ����", 1, 10, 2));
    }
}
