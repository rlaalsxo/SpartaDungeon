using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStats baseStats;
    public CharacterStats CurrentStats { get; private set; }
    public List<CharacterStats> statsModifiers = new List<CharacterStats>();
    private void Awake()
    {
        UpdateCharacterStats();
    }
    void UpdateCharacterStats()
    {
        AttackSO attackSO = null;
        if(baseStats.attackSO != null)
        {
            attackSO = Instantiate(baseStats.attackSO);
        }
        CurrentStats = new CharacterStats { attackSO = attackSO };

        CurrentStats.statsChangeType = baseStats.statsChangeType;
        CurrentStats.level = baseStats.level;
        CurrentStats.attack = baseStats.attack;
        CurrentStats.maxHealth = baseStats.maxHealth;
        CurrentStats.gold= baseStats.gold;
        CurrentStats.def = baseStats.def;
        CurrentStats.exp = baseStats.exp;
    }
}
