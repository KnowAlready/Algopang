using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate2 : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("for문에서 block2생성");
            Instantiate(obj, new Vector3(5, 4, 0), transform.rotation);

        }
    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0)) { Instantiate(obj, new Vector3(3, 4, 0), transform.rotation);}
    }
}
