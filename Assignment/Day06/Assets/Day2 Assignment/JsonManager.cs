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

            //어셈블리 
            //var subType = Assembly.GetAssembly(typeof(Champion)).GetTypes().Where(t => t.IsSubclassOf(typeof(Champion)));


            // Json파일 name <=> 클래스타입 : 동적할당수행(상속 생성자 ch 포함)
            Type type = Type.GetType(ch.name);
            Debug.Log(ch.name);
            object obj = Activator.CreateInstance(type, ch);


            cArray[idx] = (Champion)obj;

            idx++;

        }

        // 1. Champion 클래스를 추상 클래스로 만들어주세요.
        // 가지고 있어야할 내용은 Name / HP / MP / AttckDamage / Armor / HPRegen / MPRegen 이며 Name(string)을 제외하고
        // 모두 float 입니다.

        // 2. Champion 클래스에 SkillQ / SkillW / SkillE / SkillR 을 추상메소드로 만들어주세요.

        // 3. Champion 클래스를 상속받는 각각 캐릭터이름의 클래스를 만들어주세요.
        // 상속받은 추상 메소드 내용 또한 구현해주세요.

        // (보너스 문제) 4. 하기의 내용을 참고하여 캐릭터이름을 사용한 클래스를 선언 및 인스턴스화 해주세요
        // 인스턴싱한 내용은 cArray에 담아주세요.
        // https://docs.microsoft.com/en-us/dotnet/api/System.Activator?view=net-6.0
        // Hint : 현재 JSON 안의 챔피언의 이름은 첫 글자가 소문자 입니다. 이를 유의하여 선언해주세요.


        // 5. ICharacter라는 인터페이스를 생성해주시고, HpRegenV, MpRegenV, Attack 이라는 인터페이스 함수를 선언해주세요.
        // 해당 인터페이스는 챔피언 클래스가 상속받도록 해주세요.

        // 6. 인터페이스 내용들을 구현해주세요.

        // 7. cArray에 담긴 인스턴스들의 Q Skill을 발동하는 코드를 작성해주세요.

        foreach (var item in cArray)
        {
            item.SkillQ();
        }
    }
}
