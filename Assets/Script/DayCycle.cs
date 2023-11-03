using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
    float _rotacion = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(50, -30, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rotacion += 1;

        transform.rotation = Quaternion.Euler(_rotacion, 0 , 0);
    }
}
