using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alistar : Champion
{
    public Alistar(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" 알리스타 Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" 알리스타 W ");
    }
    public override void SkillE()
    {
        Debug.Log(" 알리스타 E ");
    }
    public override void SkillR()
    {
        Debug.Log(" 알리스타 R ");
    }
}
