using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    //new gameObjects defined so cameras can be controlled
    public GameObject mainCamera;
    public GameObject PovCamera;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //condtional clause defined so that depressing left control or left alt changes view. Default inputs Fire1 and Fire2 used to simplify process
     if (Input.GetButtonDown("Fire1"))
        {
            mainCamera.SetActive(true);
            PovCamera.SetActive(false);
        }
     if (Input.GetButtonDown("Fire2"))
        {
            mainCamera.SetActive(false);
            PovCamera.SetActive(true);
        }
    }
}
