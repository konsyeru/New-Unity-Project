using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    Timer timer;
    int[][][] Time = ContentInformation.Time;
    float[][] Intensity = ContentInformation.Intensity;
    int[][] Color = ContentInformation.Color;
    Color[] colors = {new Color(1f, 1f, 1f, 255f), new Color(1,0.02f,0.5f,255), new Color(1, 0, 0, 255), new Color(1,0.4f,0.03f,255), new Color(0.86f,1,0.02f,255), new Color(0, 1, 0, 255), new Color(0, 0, 1, 255)};
    Light[][] Light = new Light[6][];
    int[] IntensityCoefficient = {25, 25, 400, 400, 400, 400};
    void Start()
    {
        timer = GameObject.Find("Canvas").transform.Find("Timer/Text").gameObject.GetComponent<Timer>();
        TakeLight();
    }

    void Update()
    {
        int now_time = timer.minute * 60 + (int)timer.seconds;
        
        for(int i = 0; i < Time.Length; i++){  //ライトの種類
            if(Time[i] == null){  //Null値の場合エラーが出るため値を0で埋める
                Time[i] = new int[1][];
                Time[i][0] = new int[2];
                Time[i][0][0] = 0;
                Time[i][0][1] = 0;
                Intensity[i] = new float[1];
                Intensity[i][0] = 0;
                if(i == 2 || i == 3){
                    Color[i - 2] = new int[1];
                    Color[i - 2][0] = 0;
                }
            }

            for(int j = 0; j < Time[i].Length; j++){  //パネルの数
                if(Time[i][j][0] == now_time){
                    for(int k = 0; k < Light[i].Length; k++){  //ライトの数
                        Light[i][k].intensity = Intensity[i][j] * IntensityCoefficient[i];
                        if(i == 2 || i == 3){
                            Light[i][k].color = colors[Color[i - 2][j]];
                        }
                    }
                }else if(Time[i][j][1] == now_time){
                    for(int k = 0; k < Light[i].Length; k++){  //ライトの数
                        Light[i][k].intensity = 0;
                    }
                }
            }
        }
        
    }

    void TakeLight(){  //全てのライトのLightコンポーネントを取得
        string[] lightname = {"ss", "splight", "pinspotlight", "h", "cl", "fr"};
        GameObject[][] light = new GameObject[6][];
        for(int i = 0; i < 6; i++){
            GameObject[] obj = GameObject.FindGameObjectsWithTag(lightname[i]);
            Light[i] = new Light[obj.Length];
            for(int j = 0; j < obj.Length; j++){
                Light[i][j] = obj[j].GetComponent<Light>();
            }
        }
    }

}
