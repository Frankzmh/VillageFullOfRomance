using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {

    /// <summary>
    /// 自身的GameObject
    /// </summary>
    protected GameObject SelfGameObject;

    /// <summary>
    /// 自身的Transform
    /// </summary>
    protected Transform SelfTransform;


    protected void Awake()
    {
        SelfGameObject = gameObject;

        SelfTransform = transform;
    }
}
