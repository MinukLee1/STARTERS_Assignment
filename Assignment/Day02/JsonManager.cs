 using System;
using UnityEngine;

[Serializable] 
public class ChampionClasses
{
    public ChampionClass[] champs;
}

[Serializable]
public class ChampionClass
{
    public string id;
    public string key;
    public string name;
    public string title;
    public string[] tags;
    public Stats stats;
    public string icon;
    public SpriteC sprite;
    public string description;
    
}

[Serializable]
public class SpriteC
{
    public string url;
    public int x;
    public int y;
}

[Serializable]
public class Stats
{
    public int hp;
    public int hpperlevel;
    public int mp;
    public int mpperlevel;
    public float movespeed;
    public float armor;
    public float armorperlevel;
    public float spellblock;
    public float spellblockperlevel;
    public float attackrange;
    public float hpregen;
    public float hpregenperlevel;
    public float mpregen;
    public float mpregenperlevel;
    public float crit;
    public float critperlevel;
    public float attackdamage;
    public float attackdamageperlevel;
    public float attackspeedperlevel;
    public float attackspeed;
}





public class JsonManager : MonoBehaviour
{
    public TextAsset textAsset;
    void Start()
    {
        Ahri ahri = new Ahri();
        Akali akali = new Akali();
        Alister alister = new Alister();
        Amumu amumu = new Amumu();
        Ashe ashe = new Ashe();


        Debug.Log(textAsset.text);
        ChampionClasses c = new ChampionClasses();
        c = JsonUtility.FromJson<ChampionClasses>(textAsset.text);

        
        Debug.Log(c.champs.Length);
        

        foreach (var ch in c.champs)
        {
            if (ahri.Name == ch.name)
            {
                ahri.ImportChar(ch);
            }
            else if (akali.Name == ch.name)
            {
                akali.ImportChar(ch);
            }
            else if (amumu.Name == ch.name)
            {
                amumu.ImportChar(ch);
            }
            else if (alister.Name == ch.name)
            {
                alister.ImportChar(ch);
            }
            else if (ashe.Name == ch.name)
            {
                ashe.ImportChar(ch);
            }

        }

                    // TODO Something   
        }
 


}
    


