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
    public Weapon(string _name, int _attack, int _hp, float _def)
    {
        name = _name;
        attack = _attack;
        hp = _hp;
        def = _def;
    }
}
public class Armor : Item
{
    public Armor(string _name, int _attack, int _hp, float _def)
    {
        name = _name;
        attack = _attack;
        hp = _hp;
        def = _def;
    }
}
