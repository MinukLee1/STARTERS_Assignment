using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Annie : Champion
{
    public Annie(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" �ִ� Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" �ִ� W ");
    }
    public override void SkillE()
    {
        Debug.Log(" �ִ� E ");
    }
    public override void SkillR()
    {
        Debug.Log(" �ִ� R ");
    }
}
