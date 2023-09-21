using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string name { get; set; }
    public int attack { get; set; }
    public float def { get; set; }
    public int hp { get; set; }
}
public class Weapon : Item
{
    public Weapon(string name)
    {
        
    }
}
