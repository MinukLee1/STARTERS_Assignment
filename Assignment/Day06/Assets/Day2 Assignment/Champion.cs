using System;
using UnityEngine;

    abstract public class Champion : ICharacter
{
    public float Hp = 0;
    public float HpRegen = 0;
    public float Mp = 0;
    public float MpRegen = 0;
    public float AttckDamage = 0;
    public float Armor = 0;
    public string Name = "";


    // 클래스 생성자를 선언
    public Champion(ChampionClass ch)
    {
        Hp = ch.stats.hp;
        HpRegen = ch.stats.hpregen;
        Mp = ch.stats.mp;
        MpRegen = ch.stats.mpregen;
        AttckDamage = ch.stats.attackdamage;
        Armor = ch.stats.armor;
        Name = ch.name;
    }

    public abstract void SkillQ();
    public abstract void SkillW();
    public abstract void SkillE();
    public abstract void SkillR();



}