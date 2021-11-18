using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletPrehubAndMoveLight : MonoBehaviour
{
    MoveSpotLight script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("PinSpotLight").GetComponent<MoveSpotLight>(); 
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonDown(1)){
            Destroy(gameObject);
            script.MoveLight();
        }
    }
}
