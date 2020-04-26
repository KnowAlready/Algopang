using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Instantiate : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Debug.Log("for문에서 block1생성");
            Instantiate(obj, new Vector3(3, 4, 0), transform.rotation);

        }
    }

    void Update()
    {
    
        //if (Input.GetMouseButtonDown(0)) { }

    }
}
