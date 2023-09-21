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
    [Range(1, 100)] public int attack;
    [Range(1, 100)] public int maxHealth;
    [Range(0f, 20f)] public float def;

    //공격 데이터
    public AttackSO attackSO;
}
