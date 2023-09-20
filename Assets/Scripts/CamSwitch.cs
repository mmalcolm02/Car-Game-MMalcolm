using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject PoVCamera;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetButtonDown("Fire1"))
        {
            mainCamera.SetActive(true);
            PoVCamera.SetActive(false);
        }
     if (Input.GetButtonDown("Fire2"))
        {
            mainCamera.SetActive(false);
            PoVCamera.SetActive(true);
        }
    }
}
