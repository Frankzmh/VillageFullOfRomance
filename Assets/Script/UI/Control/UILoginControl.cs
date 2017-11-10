using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILoginControl : Base {

    private UILoginView mView;

    private new void Awake()
    {
        base.Awake();

        mView = SelfGameObject.GetComponent<UILoginView>();

        UIEventListener.Get(mView.BtnLogin).onClick = OnBtnLoginDelegate;
        UIEventListener.Get(mView.BtnRegister).onClick = OnBtnRegisterDelegate;

    }

    /// <summary>
    /// 登录按钮的点击委托
    /// </summary>
    /// <param name="go"></param>
    private void OnBtnLoginDelegate(GameObject go)
    {
        Debug.Log("登录！！！！！！！！！！");
    }

    /// <summary>
    /// 注册按钮的点击委托
    /// </summary>
    /// <param name="go"></param>
    private void OnBtnRegisterDelegate(GameObject go)
    {
        Debug.Log("注册！！！！！！！！！！");
    }
}
