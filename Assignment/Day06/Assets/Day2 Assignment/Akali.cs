using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Akali : Champion
{
    public Akali(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" ¾ÆÄ®¸® Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" ¾ÆÄ®¸® W ");
    }
    public override void SkillE()
    {
        Debug.Log(" ¾ÆÄ®¸® E ");
    }
    public override void SkillR()
    {
        Debug.Log(" ¾ÆÄ®¸® R ");
    }
}
