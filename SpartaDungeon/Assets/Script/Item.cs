using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int type { get; set; }
    public string name { get; set; }
    public int attack { get; set; }
    public float def { get; set; }
    public int hp { get; set; }
    public bool eq { get; set; }
}
public class Weapon : Item
{
    public Weapon(string _name, int _attack, int _hp, float _def, bool _eq)
    {
        type = 0;
        name = _name;
        attack = _attack;
        hp = _hp;
        def = _def;
        eq = _eq;
    }
}
public class Armor : Item
{
    public Armor(string _name, int _attack, int _hp, float _def, bool _eq)
    {
        type = 1;
        name = _name;
        attack = _attack;
        hp = _hp;
        def = _def;
        eq = _eq;
    }
}
