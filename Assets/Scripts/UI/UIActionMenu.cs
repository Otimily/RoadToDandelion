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
        // 전투 버튼을 누르면 인벤토리 씬으로 넘어간다.

        btnActive.onClick.AddListener(OnClickActive);
        // 전투 버튼을 누르면 활동 씬으로 넘어간다.
    }

    void OnClickInventory()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Inventory);
        // 인벤토리 씬으로 넘어가게 한다.
    }

    void OnClickActive()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Active);
        // 활동 씬으로 넘어가게 한다.
    }
}
