using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveSpotLight : MonoBehaviour
{

    GameObject PinSpotLight;
    Mouse script; 
    string address = "Assets/Materials/Sphere.prefab";
    GameObject targetPrefab;

    // Start is called before the first frame update
    void Start()
    {   
        script = GameObject.Find("Empty").GetComponent<Mouse>(); 
        PinSpotLight = this.gameObject;
        targetPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(address);
    }
    
    IEnumerator Delay(){
        for (int i = 0; i < script.mouse_pos.Length; i++){
            PinSpotLight.transform.LookAt(script.mouse_pos[i]);
            if (i == script.mouse_pos.Length-1){
                script.mouse_pos = new Vector3[0];
            }
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }

    public void MoveLight(){
        StartCoroutine("Delay");
    }

}
