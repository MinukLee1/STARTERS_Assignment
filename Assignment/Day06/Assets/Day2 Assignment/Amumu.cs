using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amumu : Champion
{
    public Amumu(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" �ƹ��� Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" �ƹ��� W ");
    }
    public override void SkillE()
    {
        Debug.Log(" �ƹ��� E ");
    }
    public override void SkillR()
    {
        Debug.Log(" �ƹ��� R ");
    }
}
