using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using UnityEngine.UI;

public class AddDeleteButton : MonoBehaviour
{
    public int ChildCount;
    GameObject Content, Panel, targetPrefab;
    string address = "Assets/Materials/Panel.prefab";

    // Start is called before the first frame update
    void Start()
    {
        Content = GameObject.Find("Canvas").transform.Find("Scroll View/Viewport/Content").gameObject;
        targetPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(address);
    }

    public void AddClick(){
        if(LightChange.DropdownValue != 2 && LightChange.DropdownValue != 3){  //Pin, HL以外
            Panel = (GameObject)Instantiate(targetPrefab,Content.transform.position, Quaternion.identity);
            Panel.transform.SetParent(Content.transform, false);
            Panel.transform.Find("Dropdown").gameObject.SetActive (false);
            Panel.transform.Find("Text5").gameObject.SetActive (false);
        }else{
            Panel = (GameObject)Instantiate(targetPrefab,Content.transform.position, Quaternion.identity);
            Panel.transform.SetParent(Content.transform, false);
        }
    }

    public void DeleteClick(){
        ChildCount = Content.transform.childCount;
        Destroy(Content.transform.GetChild(ChildCount-1).gameObject);
    }

}
