using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIActionMenu : MonoBehaviour
{
    public Button btnBag;
    public Button btnActive;

    void Start()
    {
        btnBag.onClick.AddListener(OnClickInventory);
        // ���� ��ư�� ������ �κ��丮 ������ �Ѿ��.

        btnActive.onClick.AddListener(OnClickActive);
        // ���� ��ư�� ������ Ȱ�� ������ �Ѿ��.
    }

    void OnClickInventory()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Inventory);
        // �κ��丮 ������ �Ѿ�� �Ѵ�.
    }

    void OnClickActive()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Active);
        // Ȱ�� ������ �Ѿ�� �Ѵ�.
    }
}
