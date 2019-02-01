﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public virtual void Hide() {
        gameObject.SetActive(false);
    }

    public virtual void Show() {
        gameObject.SetActive(true);
    }
}
