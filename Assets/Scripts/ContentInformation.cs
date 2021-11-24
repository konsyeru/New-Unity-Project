using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContentInformation : MonoBehaviour
{
    GameObject Content;
    public int ChildCount;
    public GameObject[] ChildObject;

    static public int[,] TimeSS, TimeSP, TimeHL, TimeSL, TimeFR;
    static public float[] IntensitySS, IntensitySP, IntensityHL, IntensitySL, IntensityFR;
    static public int[] ColorHL;

    // Start is called before the first frame update
    void Start()
    {
        Content = GameObject.Find("Canvas").transform.Find("Scroll View/Viewport/Content").gameObject;  //Contentを取得
        ChildCount = Content.transform.childCount;  //Contentの子オブジェクトの要素数を取得
        ChildObject = new GameObject[ChildCount];  //Content子オブジェクトを格納するための配列

        for(int i = 0; i < ChildCount; i++){  //ChiledObjectにObjectを格納
            ChildObject[i] = Content.transform.GetChild(i).gameObject;
        }

        //配列の用意
        if(LightChange.DropdownValue == 0){  //SS
            TimeSS = new int[ChildCount , 2];
            IntensitySS = new float[ChildCount];
        }else if(LightChange.DropdownValue == 1){  //SP
            TimeSP = new int[ChildCount , 2];
            IntensitySP = new float[ChildCount];
        }else if(LightChange.DropdownValue == 3){  //HL
            TimeHL = new int[ChildCount , 2];
            IntensityHL = new float[ChildCount];
            ColorHL = new int[ChildCount];
        }else if(LightChange.DropdownValue == 4){  //SL
            TimeSL = new int[ChildCount , 2];
            IntensitySL = new float[ChildCount];
        }else if(LightChange.DropdownValue == 5){  //FR
            TimeFR = new int[ChildCount , 2];
            IntensityFR = new float[ChildCount];
        }

    }


    void SaveInformation(int[,] time, float[] intensity, bool color=false){  //配列に情報を保存
        for(int i = 0; i < ChildCount; i++){
            //Time:秒に直して保存
            int start_minute = int.Parse(ChildObject[i].transform.Find("InputField1-1").gameObject.GetComponent<TMP_InputField>().text);
            int start_second = int.Parse(ChildObject[i].transform.Find("InputField1-2").gameObject.GetComponent<TMP_InputField>().text);
            int end_minute = int.Parse(ChildObject[i].transform.Find("InputField2-1").gameObject.GetComponent<TMP_InputField>().text);
            int end_second = int.Parse(ChildObject[i].transform.Find("InputField2-2").gameObject.GetComponent<TMP_InputField>().text);
            time[i, 0] = start_minute*60+start_second;
            time[i, 1] = end_minute*60+end_second;
            //Intensity
            intensity[i] = ChildObject[i].transform.Find("Slider").gameObject.GetComponent<Slider>().value;
            //color
            if(color){
                ColorHL[i] = ChildObject[i].transform.Find("Dropdown").gameObject.GetComponent<TMP_Dropdown>().value;
            }
        }
    }

    public void Click(){
        if(LightChange.DropdownValue == 0){        //SS
            SaveInformation(TimeSS, IntensitySS);
        }else if(LightChange.DropdownValue == 1){  //SP
            SaveInformation(TimeSP, IntensitySP);
        }else if(LightChange.DropdownValue == 3){  //HL
            SaveInformation(TimeHL, IntensityHL, true);
        }else if(LightChange.DropdownValue == 4){  //SL
            SaveInformation(TimeSL, IntensitySL);
        }else if(LightChange.DropdownValue == 5){  //FR
            SaveInformation(TimeFR, IntensityFR);
        }        
    }

}
