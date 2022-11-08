using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladronesply : MonoBehaviour
{
    public Transform posPlayer;
    public float speed = 2f;
    void Update()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        transform.position = Vector3.Lerp(transform.position, posPlayer.position, speed * Time.deltaTime);

        float dist = Vector3.Distance(posPlayer.position, transform.position);

        if (dist < 2)
        {
            speed = 0;
        }

        if (dist > 2)
        {
            speed = 2;
        }
    }
}


    
