using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionLuces : MonoBehaviour
{
    public float rotacion;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.rotation += new Vector3(0,rotacion,0);
    }
}
