using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject objectToClone;

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {

            Instantiate(objectToClone);
        }
    }
}
