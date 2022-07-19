using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ashe : Champion
{
    public Ashe(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" 局浆 Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" 局浆 W ");
    }
    public override void SkillE()
    {
        Debug.Log(" 局浆 E ");
    }
    public override void SkillR()
    {
        Debug.Log(" 局浆 R ");
    }
}
