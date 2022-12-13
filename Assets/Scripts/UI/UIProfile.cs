using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIProfile : MonoBehaviour
{
    public Slider hpBar;
    public Image imgHpFill; // �̹��� ü�¹� �÷�
    public TMP_Text txtHp;

    public Slider expBar;
    public Image imgExpFill; // �̹��� ����ġ�� �÷�
    public TMP_Text txtExp;

    public TMP_Text txtLevel;
    public TMP_Text txtName;
    public TMP_Text txtGold;

    void Start()
    {
        RefreshState();
    }

    public void RefreshState() //�Լ��� �����Ű���� �� ���̴�.
    {
        txtLevel.text = $"Lv.{GameManager.GetInstance().levle}";
        txtName.text = $"{GameManager.GetInstance().playerName}";
        txtGold.text = $"{GameManager.GetInstance().gold}g";
        // GetInstance() �� �����ϱ�

        //�̰��� float�̴�. �׷��� value��� int�� ���� ���� �ִ�.(HP)
        hpBar.maxValue = GameManager.GetInstance().totalHP;
        hpBar.value = GameManager.GetInstance().curHp;
        txtHp.text = $"{hpBar.value} / {hpBar.maxValue}";

        //exp����ġ�� ������ ���� ����ġ�� �������� ������ �ö󰡵��� ����
        expBar.maxValue = GameManager.GetInstance().totalEXP;
        expBar.value = GameManager.GetInstance().curExp;
        txtExp.text = $"{expBar.value} / {expBar.maxValue}";

    }
}
