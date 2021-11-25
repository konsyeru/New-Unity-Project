using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class LoadData : MonoBehaviour
{
    GameObject Content, Panel, targetPrefab;
    string address = "Assets/Materials/Panel.prefab";
    void Start()
    {
        Content = GameObject.Find("Canvas").transform.Find("Scroll View/Viewport/Content").gameObject;
        targetPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(address);
        LoadInformation();
    }

    void AddPanel(){
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
    void LoadInformation(){
        for(int i = 0; i < ContentInformation.ChildCounts[LightChange.DropdownValue]; i++){
            AddPanel();
            GameObject PanlObject = Content.transform.GetChild(i).gameObject;
            //Time
            PanlObject.transform.Find("InputField1-1").gameObject.GetComponent<TMP_InputField>().text = (ContentInformation.Time[LightChange.DropdownValue][i][0] / 60).ToString();
            PanlObject.transform.Find("InputField1-2").gameObject.GetComponent<TMP_InputField>().text = (ContentInformation.Time[LightChange.DropdownValue][i][0] % 60).ToString();
            PanlObject.transform.Find("InputField2-1").gameObject.GetComponent<TMP_InputField>().text = (ContentInformation.Time[LightChange.DropdownValue][i][1] / 60).ToString();
            PanlObject.transform.Find("InputField2-2").gameObject.GetComponent<TMP_InputField>().text = (ContentInformation.Time[LightChange.DropdownValue][i][1] % 60).ToString();
            //Intensity
            PanlObject.transform.Find("Slider").gameObject.GetComponent<Slider>().value = ContentInformation.Intensity[LightChange.DropdownValue][i];
             //color
            if(LightChange.DropdownValue == 2 || LightChange.DropdownValue == 3){
                PanlObject.transform.Find("Dropdown").gameObject.GetComponent<TMP_Dropdown>().value = ContentInformation.Color[LightChange.DropdownValue - 2][i];
            }
        }
    }

}
