using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amumu : Champion
{
    public Amumu(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" 酒公公 Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" 酒公公 W ");
    }
    public override void SkillE()
    {
        Debug.Log(" 酒公公 E ");
    }
    public override void SkillR()
    {
        Debug.Log(" 酒公公 R ");
    }
}
