using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

public class PlayMouse : MonoBehaviour
{

    public Vector3 mouse_raw_pos;
    public Vector3[] mouse_pos = new Vector3[0];
    Vector3 mouse_screen_pos;
    GameObject PinSpotLight;

    // Start is called before the first frame update
    void Start()
    {
        PinSpotLight = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //　マウスポインタの位置を取得
        mouse_screen_pos = Input.mousePosition;
        mouse_screen_pos.z = 30;//18.5f;
        mouse_raw_pos = Camera.main.ScreenToWorldPoint(mouse_screen_pos);
        PinSpotLight.transform.LookAt(mouse_raw_pos);
        //Debug.Log("x:" + mouse_raw_pos.x + ", y:" + mouse_raw_pos.y);
        //Array.Resize(ref mouse_pos, mouse_pos.Length + 1);
        //mouse_pos[mouse_pos.Length - 1] = mouse_raw_pos;
        //Debug.Log(mouse_pos[mouse_pos.Length - 1]);
        
    }
}
