using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Annie : Champion
{
    public Annie(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" 局聪 Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" 局聪 W ");
    }
    public override void SkillE()
    {
        Debug.Log(" 局聪 E ");
    }
    public override void SkillR()
    {
        Debug.Log(" 局聪 R ");
    }
}
