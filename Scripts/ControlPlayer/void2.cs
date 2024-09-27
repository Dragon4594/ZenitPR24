using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class void2 : MonoBehaviour
{
    public Transform g;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = g.transform.position;
    }
}
