using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Light lt;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        
         color = new Color(1, 1, 1, 255);
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
        }else if(Input.GetKeyDown(KeyCode.O)){
            color = new Color(1,0.4f,0.03f,255);
        }else if(Input.GetKeyDown(KeyCode.P)){
            color = new Color(1,0.02f,0.5f,255);
        }else if(Input.GetKeyDown(KeyCode.Y)){
            color = new Color(0.86f,1,0.02f,255);
        }
    }
}
