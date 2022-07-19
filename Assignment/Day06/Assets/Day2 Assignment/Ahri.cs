using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ahri : Champion 
{
    public Ahri(ChampionClass ch) : base(ch) { }

    public override void SkillQ()
    {
        Debug.Log(" 아리 Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" 아리 W ");
    }
    public override void SkillE()
    {
        Debug.Log(" 아리 E ");
    }
    public override void SkillR()
    {
        Debug.Log(" 아리 R ");
    }

}
