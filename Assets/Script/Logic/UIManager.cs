using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Base {

    /// <summary>
    /// UI 的枚举
    /// </summary>
    public enum UIName
    {
        Login = 0,
    }

    /// <summary>
    /// UI名字列表
    /// </summary>
    public static string[] UINameStr = new string[]{
        "UILogin",
    };

    /// <summary>
    /// UI父节点的名字
    /// </summary>
    private string mUIRootStr = "UI Root";

    /// <summary>
    /// UI的父节点
    /// </summary>
    public Transform UIRoot;

    private void Awake()
    {
        base.Awake();
        UIRoot = SelfTransform.Find(mUIRootStr);
    }

    /// <summary>
    /// 载入UI资源
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public GameObject LoadUI(UIName name)
    {
        GameObject ui = null;
        string nameStr = UINameStr[(int)name];
        Object oriRes = Resources.Load(nameStr);
        if (oriRes == null)
        {
            Debug.LogError("nameStr 不存在！");
            return ui;
        }

        ui = Instantiate(oriRes) as GameObject;
        if (ui != null)
        {
            ui.transform.SetParent(UIRoot);
            ui.transform.localScale = Vector3.one;
            ui.transform.localPosition = Vector3.zero;
        }
        return ui;
    }


}
