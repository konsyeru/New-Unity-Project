using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{

    public Vector3 mouse_raw_pos;
    public Vector3[] mouse_pos = new Vector3[0];
    string address = "Assets/Materials/Sphere.prefab";
    GameObject targetPrefab;
    Vector3 mouse_screen_pos;
    [SerializeField]public Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        targetPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(address);
    }

    // Update is called once per frame
    void Update()
    {
        if(dropdown.value==2){
            //　マウスポインタの位置を取得
            if(Input.GetMouseButton(0)){
                mouse_screen_pos = Input.mousePosition;
                mouse_screen_pos.z = 18.5f;
                mouse_raw_pos = Camera.main.ScreenToWorldPoint(mouse_screen_pos);
                //Debug.Log("x:" + mouse_raw_pos.x + ", y:" + mouse_raw_pos.y);
                Array.Resize(ref mouse_pos, mouse_pos.Length + 1);
                mouse_pos[mouse_pos.Length - 1] = mouse_raw_pos;
                //Debug.Log(mouse_pos[mouse_pos.Length - 1]);
                Instantiate(targetPrefab, mouse_pos[mouse_pos.Length - 1], Quaternion.identity);
            }

        }
        
    }
}
