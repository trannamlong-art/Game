using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcamera : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + new Vector3(0 , 5 , -8);
    }
}
