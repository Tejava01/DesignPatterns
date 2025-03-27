using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    private ObjectPool pool;

    private void Update()
    {
        if (this.transform.position.y < -50)
        {
            pool.ReturnToPool(this);
        }
    }

    public void SetPool(ObjectPool objectPool)
    {
        pool = objectPool;
    }
}
