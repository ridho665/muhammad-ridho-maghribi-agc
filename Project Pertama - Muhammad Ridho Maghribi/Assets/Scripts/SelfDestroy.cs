using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{  
    public int destroyTimer;
    void Start()
    {
        Destroy(gameObject, destroyTimer);
    }

}
