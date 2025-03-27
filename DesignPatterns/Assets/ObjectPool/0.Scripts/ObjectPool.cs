using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private int poolSize = 5;
    [SerializeField] private PoolObject poolObj;

    private Queue<PoolObject> poolQ;

    private void Start()
    {
        SettingPool();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PoolObject poolObj = GetToPool();
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.farClipPlane;
            poolObj.transform.position = Camera.main.ScreenToWorldPoint(mousePos);

            Rigidbody rb = poolObj.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    private void SettingPool()
    {
        poolQ = new Queue<PoolObject>();
        PoolObject instance = null;

        for (int i = 0; i < poolSize; i++)
        {
            instance = Instantiate(poolObj);
            instance.SetPool(this);
            instance.transform.SetParent(this.transform);
            instance.gameObject.SetActive(false);
            poolQ.Enqueue(instance);
        }
    }

    private PoolObject GetToPool()
    {
        if (poolQ.Count == 0)
        {
            PoolObject newInstance = Instantiate(poolObj);
            newInstance.SetPool(this);
            newInstance.transform.SetParent(this.transform);
            return newInstance;
        }

        PoolObject nextInstance = poolQ.Dequeue();
        nextInstance.gameObject.SetActive(true);
        return nextInstance;
    }

    public void ReturnToPool(PoolObject poolObj)
    {
        poolQ.Enqueue(poolObj);
        poolObj.gameObject.SetActive(false);
    }
}
