using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Akali : Champion
{
    public Akali(ChampionClass ch) : base(ch) { }
    public override void SkillQ()
    {
        Debug.Log(" ��Į�� Q ");
    }
    public override void SkillW()
    {
        Debug.Log(" ��Į�� W ");
    }
    public override void SkillE()
    {
        Debug.Log(" ��Į�� E ");
    }
    public override void SkillR()
    {
        Debug.Log(" ��Į�� R ");
    }
}
