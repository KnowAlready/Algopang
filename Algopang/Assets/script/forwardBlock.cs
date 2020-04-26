using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class forwardBlock : MonoBehaviour
{
    //public GameObject player;

    private float h;
    private float v;
    private int speed = 10;

    public GameObject obj;


    void Start()
    {
        //obj = (GameObject)AssetDatabase.LoadAssetAtPath("Prefabs/player", typeof(GameObject));
        //obj = Resources.Load<GameObject>("Prefabs/player");
        //Debug.Log(Resources.Load<GameObject>("Prefabs/player"));

    }

    void Update()
    {
        h = 0; 
        v = 0;

        Debug.Log("프리팹 가져오기");
        Debug.Log(obj);

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (this.GetComponent<Collider2D>().OverlapPoint(mousePosition))
            {
                Debug.Log("마우스 클릭");
                h = speed * Time.deltaTime;
                obj.transform.Translate(new Vector3(h, v, 0));
                Debug.Log("마우스 클릭 후");
            }

        }

     }
}
