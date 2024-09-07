using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleDestroy : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 0.1f);
    }
}
