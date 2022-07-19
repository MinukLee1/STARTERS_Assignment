using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ashe : Champion
{
    public Ashe(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" 애쉬 Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" 애쉬 W ");
    }
    public override void SkillE()
    {
        Debug.Log(" 애쉬 E ");
    }
    public override void SkillR()
    {
        Debug.Log(" 애쉬 R ");
    }
}
