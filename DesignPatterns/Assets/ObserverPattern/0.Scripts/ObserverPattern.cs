using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObserverPattern : MonoBehaviour
{
    [SerializeField] private Button TeleportBtn;
    public event Action OnCliked;

    private void Start()
    {
        TeleportBtn.onClick.AddListener(OnClik);
    }

    private void OnClik()
    {
        if(OnCliked != null)
        {
            OnCliked();
        }
    }
}
