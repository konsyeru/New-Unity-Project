using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlightkouryou : MonoBehaviour
{
    // Start is called before the first frame update
    Light lt;
    void Start()
    {
        lt = GetComponent<Light>();
        lt.intensity = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            if(lt.intensity < 25){
                lt.intensity += 1;
            }
        }else if(Input.GetKey(KeyCode.DownArrow)){
            if(lt.intensity > 0){
                lt.intensity -= 1;
            }
        } 
    }
}
