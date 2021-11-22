using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletPrehubAndMoveLight : MonoBehaviour
{
    MoveSpotLight script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            script = GameObject.Find("PinSpotLight").GetComponent<MoveSpotLight>(); 
            if(Input.GetMouseButtonDown(1)){
                Destroy(gameObject);
                script.MoveLight();
            }
    }
}
