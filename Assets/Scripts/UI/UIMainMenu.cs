using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    // �� ��ũ��Ʈ�� Main������ �� �� �ְ� �۵����ش�.
    Button btnStart;

    void Start()
    {
        btnStart = GetComponentInChildren<Button>();
        btnStart.onClick.AddListener(OnClickStart);
    }

    void OnClickStart()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Main);
    }
}
