using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]
public class CharacterStats
{
    public StatsChangeType statsChangeType;
    [Range(1, 100)] public int level;
    [Range(1, 100)] public int attack;
    [Range(1, 100)] public int maxHealth;
    [Range(0, 100000)] public int gold;
    [Range(0f, 20f)] public float def;
    public float exp;


    //공격 데이터
    public AttackSO attackSO;
}
