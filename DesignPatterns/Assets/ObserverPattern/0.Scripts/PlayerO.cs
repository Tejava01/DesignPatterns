using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerO : MonoBehaviour
{
    private void Awake()
    {
        ObserverPattern.OnCliked += Teleport;
    }

    private void OnDestroy()
    {
        ObserverPattern.OnCliked -= Teleport;
    }

    private void Teleport()
    {
        Vector3 pos = transform.position;
        pos.x = Random.Range(-5f, 5f);
        transform.position = pos;
    }
}
