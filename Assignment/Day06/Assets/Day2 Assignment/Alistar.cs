using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alistar : Champion
{
    public Alistar(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" �˸���Ÿ Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" �˸���Ÿ W ");
    }
    public override void SkillE()
    {
        Debug.Log(" �˸���Ÿ E ");
    }
    public override void SkillR()
    {
        Debug.Log(" �˸���Ÿ R ");
    }
}
