using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerPoV : MonoBehaviour
{
    public GameObject player;
    private Vector3 closeview = new Vector3(0, 1.9f, 2.6f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = player.transform.position + closeview;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
