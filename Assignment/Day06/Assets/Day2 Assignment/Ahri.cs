using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ahri : Champion 
{
    public Ahri(ChampionClass ch) : base(ch) { }

    public override void SkillQ()
    {
        Debug.Log(" �Ƹ� Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" �Ƹ� W ");
    }
    public override void SkillE()
    {
        Debug.Log(" �Ƹ� E ");
    }
    public override void SkillR()
    {
        Debug.Log(" �Ƹ� R ");
    }

}
