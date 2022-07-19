using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
using Unity.VisualScripting;
using Object = System.Object;
using System.Reflection;
using System.Linq;

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
    public float hp;
    public int hpperlevel;
    public float mp;
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
        


        ChampionClasses c = new ChampionClasses();
        c = JsonUtility.FromJson<ChampionClasses>(textAsset.text);
        Champion[] cArray = new Champion[6];

        int idx = 0;

        foreach (var ch in c.champs)
        {
            Debug.Log(ch);

            //����� 
            //var subType = Assembly.GetAssembly(typeof(Champion)).GetTypes().Where(t => t.IsSubclassOf(typeof(Champion)));


            // Json���� name <=> Ŭ����Ÿ�� : �����Ҵ����(��� ������ ch ����)
            Type type = Type.GetType(ch.name);
            Debug.Log(ch.name);
            object obj = Activator.CreateInstance(type, ch);


            cArray[idx] = (Champion)obj;

            idx++;

        }

        // 1. Champion Ŭ������ �߻� Ŭ������ ������ּ���.
        // ������ �־���� ������ Name / HP / MP / AttckDamage / Armor / HPRegen / MPRegen �̸� Name(string)�� �����ϰ�
        // ��� float �Դϴ�.

        // 2. Champion Ŭ������ SkillQ / SkillW / SkillE / SkillR �� �߻�޼ҵ�� ������ּ���.

        // 3. Champion Ŭ������ ��ӹ޴� ���� ĳ�����̸��� Ŭ������ ������ּ���.
        // ��ӹ��� �߻� �޼ҵ� ���� ���� �������ּ���.

        // (���ʽ� ����) 4. �ϱ��� ������ �����Ͽ� ĳ�����̸��� ����� Ŭ������ ���� �� �ν��Ͻ�ȭ ���ּ���
        // �ν��Ͻ��� ������ cArray�� ����ּ���.
        // https://docs.microsoft.com/en-us/dotnet/api/System.Activator?view=net-6.0
        // Hint : ���� JSON ���� è�Ǿ��� �̸��� ù ���ڰ� �ҹ��� �Դϴ�. �̸� �����Ͽ� �������ּ���.


        // 5. ICharacter��� �������̽��� �������ֽð�, HpRegenV, MpRegenV, Attack �̶�� �������̽� �Լ��� �������ּ���.
        // �ش� �������̽��� è�Ǿ� Ŭ������ ��ӹ޵��� ���ּ���.

        // 6. �������̽� ������� �������ּ���.

        // 7. cArray�� ��� �ν��Ͻ����� Q Skill�� �ߵ��ϴ� �ڵ带 �ۼ����ּ���.

        foreach (var item in cArray)
        {
            item.SkillQ();
        }
    }
}
