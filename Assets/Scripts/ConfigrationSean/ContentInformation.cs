using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContentInformation : MonoBehaviour
{
    GameObject Content;
    public int ChildCount;
    static public int[] ChildCounts = {0, 0, 0, 0, 0, 0}; 
    public GameObject[] ChildObject;
    static public int[][][] Time = new int[5][][];  //TimeSS, TimeSP, TimeHL, TimeSL, TimeFR;
    static public float[][] Intensity = new float[5][]; //IntensitySS, IntensitySP, IntensityHL, IntensitySL, IntensityFR;
    static public int[] ColorHL;

    // Start is called before the first frame update
    void Start()
    {
        Content = GameObject.Find("Canvas").transform.Find("Scroll View/Viewport/Content").gameObject;  //Contentを取得
    }

    void ArrayPreparation(){ //配列を用意

        ChildCount = Content.transform.childCount;  //Contentの子オブジェクトの要素数を取得
        ChildObject = new GameObject[ChildCount];  //Content子オブジェクトを格納するための配列
        ChildCounts[LightChange.DropdownValue] = ChildCount;

        for(int i = 0; i < ChildCount; i++){  //ChiledObjectにObjectを格納
            ChildObject[i] = Content.transform.GetChild(i).gameObject;
        }

        //配列の要素数の初期化
        Time[LightChange.DropdownValue] = new int[ChildCount][];
        Intensity[LightChange.DropdownValue] = new float[ChildCount];
        ChildCounts[LightChange.DropdownValue] = ChildCount;
        if(LightChange.DropdownValue == 3){  //HL
            ColorHL = new int[ChildCount];
        }

    }

    void SaveInformation(){  //配列に情報を保存
        for(int i = 0; i < ChildCount; i++){
            //Time:秒に直して保存
            int start_minute = int.Parse(ChildObject[i].transform.Find("InputField1-1").gameObject.GetComponent<TMP_InputField>().text);
            int start_second = int.Parse(ChildObject[i].transform.Find("InputField1-2").gameObject.GetComponent<TMP_InputField>().text);
            int end_minute = int.Parse(ChildObject[i].transform.Find("InputField2-1").gameObject.GetComponent<TMP_InputField>().text);
            int end_second = int.Parse(ChildObject[i].transform.Find("InputField2-2").gameObject.GetComponent<TMP_InputField>().text);
            Time[LightChange.DropdownValue][i] = new int[2];
            Time[LightChange.DropdownValue][i][0] = start_minute * 60 + start_second; 
            Time[LightChange.DropdownValue][i][1] = end_minute * 60 + end_second;
            //Intensity
            Intensity[LightChange.DropdownValue][i] = ChildObject[i].transform.Find("Slider").gameObject.GetComponent<Slider>().value;
            //color
            if(LightChange.DropdownValue == 3){
                ColorHL[i] = ChildObject[i].transform.Find("Dropdown").gameObject.GetComponent<TMP_Dropdown>().value;
            }
        }
    }

    public void Click(){
        ArrayPreparation();  //配列を用意
        SaveInformation();  //配列に情報を保存
    }

}
