using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizonsita : MonoBehaviour
{
    public Color color;
    Light lt;
    
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        color = new Color(1, 1, 1, 255);
        lt.intensity = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //lt.color -= (Color.white / 2.0f) * Time.deltaTime;
        lt.color = color;

        //　キーボード(R,G,B)入力で色が変わる    
        if(Input.GetKeyDown(KeyCode.R)){
            color = new Color(1, 0, 0, 255);
        }else if(Input.GetKeyDown(KeyCode.G)){
            color = new Color(0, 1, 0, 255);
        }else if(Input.GetKeyDown(KeyCode.B)){
            color = new Color(0, 0, 1, 255);
        }else if(Input.GetKeyDown(KeyCode.W)){
            color = new Color(1, 1, 1, 255);
        }
        
        // 矢印キー（↑↓）で光量が変わる
        if(Input.GetKey(KeyCode.UpArrow)){
            if(lt.intensity < 500){
                lt.intensity += 10;
            }
        }else if(Input.GetKey(KeyCode.DownArrow)){
            if(lt.intensity > 0){
                lt.intensity -= 10;
            }
        } 

    }
    
}