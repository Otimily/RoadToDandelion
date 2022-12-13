using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    #region Singletone
    //이것이 싱글톤의 프로포티이다?
    public static GameManager instance = null;

    public static GameManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@GameManager"); //@를 넣는 이유는 시스템적인 것이라는 표시이다.
            instance = go.AddComponent<GameManager>();
        }

        return instance;
    }

    #endregion

    public string playerName = "ho"; // 이름

    public int levle = 11; // 레벨

    public int gold = 1000; // 돈

    public int totalHP = 100; // 최대HP
    public int curHp = 100;

    public int totalEXP = 100; // 11레벨의 경험치 상한선
    public int curExp = 0; //원래 뉴비는 경험치가 만땅이 아니고 태초마을에서 부터 시작이다.


    //====================================================================================


    public void AddGold(int gold) // 골드가 추가 삭제되고, HP가 증가하거나 감소하게 만들것이다.
    {
        this.gold += gold;
    }
    public bool SpenGold(int gold)
    {
        if(this.gold >= gold) // 성공했을 때
        {
            this.gold -= gold;
            return true;
        }

        return false; // 실패했을때는 거짓이 되게 만든다.
    }


    //====================================================================================


    public void IncreaseTotalHP(int addHp)
    {
        totalHP += addHp; // this가 없어도 된다. 
    }

    public void SetCurrentHP(int hp)
    {
        curHp += hp;

        // 100   >  100
        // 현재 체력이 최대치 체력보다는 많도록 한다는 뜻
        if(curHp > totalHP)
        {
            curHp = totalHP; // cur -> 100
        }

        // -20 < 0
        if (curHp < 0)
        {
            curHp = 0; // cur -> 0
        }

        Mathf.Clamp(curHp, 0, 100);
        // 0보다는 크고 100보다는 작아지게 해줘라고 주문하는 것이다.
        //Clamp 기능을 좀더 이해해보자. 실무에서는 이렇게 쓴다.
    }


    //====================================================================================


    public void IncreaseTotalEXP(int addExp)
    {
        totalEXP += addExp;
    }

    public void SetCurrentEXP(int exp)
    {
        curExp += exp;

        // 현재 경험치가 최대 경험치보다 많아서는 안된다.
        //if(curExp < totalEXP)
        //{
        //    curExp = ;
        //}

        if (curExp >= 0) // 경험치는 0보다 크거나 같을 수 있다.
        {
            curExp = 0;
        }

        Mathf.Clamp(curExp, 0, 100);
    }
}
