using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveSpotLight : MonoBehaviour
{

    GameObject SpotLight;
    Mouse script; 
    string address = "Assets/Materials/Sphere.prefab";
    GameObject targetPrefab;

    // Start is called before the first frame update
    void Start()
    {   
        script = GameObject.Find("Empty").GetComponent<Mouse>(); 
        SpotLight = this.gameObject;
        targetPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(address);
    }
    /*
    void Update()
    {
        if(Input.GetMouseButtonDown(2)){
            if(count){
                for(int i=0; i < script.mouse_pos.Length; i++){
                    Instantiate(targetPrefab, script.mouse_pos[i], Quaternion.identity);
                    SpotLight.transform.LookAt(script.mouse_pos[i]);
                }
                count = false;
            }
        }
    }
    */
    IEnumerator Delay(){
        for (int i=0; i < script.mouse_pos.Length; i++){
            SpotLight.transform.LookAt(script.mouse_pos[i]);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }

    public void MoveLight(){
        StartCoroutine("Delay");
    }

}
