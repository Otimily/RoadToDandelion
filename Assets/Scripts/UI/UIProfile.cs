using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIProfile : MonoBehaviour
{
    public Slider hpBar;
    public Image imgHpFill; // 이미지 체력바 컬러
    public TMP_Text txtHp;

    public Slider expBar;
    public Image imgExpFill; // 이미지 경험치바 컬러
    public TMP_Text txtExp;

    public TMP_Text txtLevel;
    public TMP_Text txtName;
    public TMP_Text txtGold;

    void Start()
    {
        RefreshState();
    }

    public void RefreshState() //함수를 실행시키도록 할 것이다.
    {
        txtLevel.text = $"Lv.{GameManager.GetInstance().levle}";
        txtName.text = $"{GameManager.GetInstance().playerName}";
        txtGold.text = $"{GameManager.GetInstance().gold}g";
        // GetInstance() 란 무엇일까

        //이것은 float이다. 그래서 value대신 int를 넣을 수도 있다.(HP)
        hpBar.maxValue = GameManager.GetInstance().totalHP;
        hpBar.value = GameManager.GetInstance().curHp;
        txtHp.text = $"{hpBar.value} / {hpBar.maxValue}";

        //exp경험치가 레벨당 제한 경험치를 넘을수록 레벨이 올라가도록 설계
        expBar.maxValue = GameManager.GetInstance().totalEXP;
        expBar.value = GameManager.GetInstance().curExp;
        txtExp.text = $"{expBar.value} / {expBar.maxValue}";

    }
}
