using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishBehaviour : MonoBehaviour
{


    void Update()
    {
        // Позиция Х постепенно меняется от текущего значения до 0
        float x = Mathf.MoveTowards(transform.position.x, 0f, Time.deltaTime * 2f);
        float z = transform.position.z + 3f * Time.deltaTime;
        transform.position = new Vector3(x, 0f, z);

        // Поворот по Y постеменно меняется от текущего значения до 0
        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0f, Time.deltaTime * 100f);
        transform.localEulerAngles = new Vector3(0,rot,0);
    }
}
