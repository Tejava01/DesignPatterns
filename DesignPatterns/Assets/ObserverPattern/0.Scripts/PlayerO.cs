using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerO : MonoBehaviour
{
    [SerializeField] private ObserverPattern observer;

    private void Awake()
    {
        observer.OnCliked += Teleport;
    }

    private void OnDestroy()
    {
        observer.OnCliked -= Teleport;
    }

    private void Teleport()
    {
        Vector3 pos = transform.position;
        pos.x = Random.Range(-5f, 5f);
        transform.position = pos;
    }
}
