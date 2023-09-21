using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMovement : MonoBehaviour
{
    //Although variable named busSpeed this will be applied to other vehicles travelling at constant speed
    private float busSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //vehicle speed based on private constant busSpeed
        transform.Translate(Vector3.forward * Time.deltaTime * busSpeed);
    }
}
