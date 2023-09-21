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
        items.Add(new Weapon("±×³É °Ë", 5, 0, 1));
        items.Add(new Armor("±×³É °©¿Ê", 1, 10, 2));
    }
}
