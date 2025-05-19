using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPattern<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
            Debug.Log(gameObject.name+" 생성");
        }
        else
        {
            Destroy(gameObject);
            Debug.Log(instance.gameObject.name+" 인스턴스가 존재하여 "+gameObject.name + " 파괴");
        }
    }

}
