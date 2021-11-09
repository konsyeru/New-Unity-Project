using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kouryou : MonoBehaviour
{
   
    Light lt;
    
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        lt.intensity = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        // 矢印キー（↑↓）で光量が変わる
        if(Input.GetKey(KeyCode.UpArrow)){
            if(lt.intensity < 400){
                lt.intensity += 10;
            }
        }else if(Input.GetKey(KeyCode.DownArrow)){
            if(lt.intensity > 0){
                lt.intensity -= 10;
            }
        } 

    }
    
}