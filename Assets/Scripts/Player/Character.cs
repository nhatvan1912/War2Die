using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    float xLimitLeft = -44f;
    float xLimitRight = 32f;
    float xLimitTop = 27f;
    float xLimitBottom = -23f;
    private Vector3 pos;
    void Update()
    {
        pos=transform.position;
        float x = Mathf.Clamp(pos.x,xLimitLeft,xLimitRight);
        float y = Mathf.Clamp(pos.y,xLimitBottom,xLimitTop);
        transform.position = new Vector3(x,y,0);
    }
}
