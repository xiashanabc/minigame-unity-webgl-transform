﻿using System.Collections;
using SLua;
using UnityEngine;

public class VarObj : MonoBehaviour
{
    LuaSvr l;

    // Use this for initialization
    void Start()
    {
        l = new LuaSvr();
        l.init(
            null,
            () =>
            {
                l.start("varobj");
            }
        );
    }
}
