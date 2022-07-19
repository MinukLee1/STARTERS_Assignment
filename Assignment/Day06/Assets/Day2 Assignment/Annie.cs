using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Annie : Champion
{
    public Annie(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" 애니 Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" 애니 W ");
    }
    public override void SkillE()
    {
        Debug.Log(" 애니 E ");
    }
    public override void SkillR()
    {
        Debug.Log(" 애니 R ");
    }
}
