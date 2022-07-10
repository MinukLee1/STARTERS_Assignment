using System;
using UnityEngine;

public class Champion
{
    public float HpV = 0;
    public float HpRegenV = 0;
    public int MpV = 0;
    public float MpRegenV = 0;
    public float AtkDmg = 0;
    public float Armor = 0;
    public string Name = "";

    void HpRegen(ChampionClass ch)
    {
        HpV = HpV + HpRegenV;
    }

    void MpRegen(ChampionClass ch)
    {

    }

    public void ImportChar(ChampionClass ch)
    {
        HpV = ch.stats.hp;
        HpRegenV = ch.stats.hpregen;
        MpV = ch.stats.mp;
        MpRegenV = ch.stats.mpregen;
        AtkDmg = ch.stats.attackdamage;
        Armor = ch.stats.armor;
        Name = ch.name;
    }


    public void Damaged(Champion Enemy)
    {
        var Left_Armor = this.Armor - Enemy.AtkDmg;
    }

}
