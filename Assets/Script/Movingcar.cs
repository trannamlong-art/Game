using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingcar : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //di chuyển chiếc xe 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
