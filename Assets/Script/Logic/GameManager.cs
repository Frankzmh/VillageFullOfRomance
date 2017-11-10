using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Base
{

    private UIManager mUIManager;

    private UILoginControl mUILogin;

    private GameObject mGameObject;

    protected new void Awake()
    {
        base.Awake();
        mUIManager = SelfGameObject.AddComponent<UIManager>();

        GameObject loginObject = mUIManager.LoadUI(UIManager.UIName.Login);
        if (loginObject != null)
        {
            mUILogin = loginObject.AddComponent<UILoginControl>();
        }
    }


}
