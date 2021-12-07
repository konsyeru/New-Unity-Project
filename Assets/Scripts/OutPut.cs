using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

public class OutPut : MonoBehaviour
{
    // Start is called before the first frame update
    string DesktopPass = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    int[][][] Time = ContentInformation.Time;
    float[][] Intensity = ContentInformation.Intensity;
    int[][] Color = ContentInformation.Color;
    string[] lightname = {"ss", "splight", "pinspotlight", "h", "cl", "fr"};
    string[] lightcolor = {"White", "Pink", "Red", "Orange", "Yellow", "Green", "Blue"};
    
    void Start()
    {
        
    }

    public void OnClick(){
        Sort();
        StreamWriter file = new StreamWriter(Path.Combine(DesktopPass, "Lighting Design.csv"), false, Encoding.UTF8);
        file.WriteLine(string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}","Light name", "Start Time"," ", "End Time"," ", "Intensity", "Color"));
        for (int i = 0; i < Time.Length; i++){
            file.WriteLine(string.Format("{0}", lightname[i]));
            for(int j = 0; j < Time[i].Length; j++){
                if(i == 2 || i == 3){
                    file.WriteLine(string.Format("{0}, {1}m, {2}s, {3}m, {4}s, {5}%, {6}", " ",Time[i][j][0]/60, Time[i][j][0]%60, Time[i][j][1]/60, Time[i][j][1]%60,(int)(Intensity[i][j] * 100), lightcolor[Color[i - 2][j]]));
                }else{
                    file.WriteLine(string.Format("{0}, {1}m, {2}s, {3}m, {4}s, {5}%", " ", Time[i][j][0]/60, Time[i][j][0]%60, Time[i][j][1]/60, Time[i][j][1]%60, (int)(Intensity[i][j] * 100)));
                }

            }
            
        }
        file.Close();
    }

    void Sort(){
        int Count = 0;
        int b = None;
        

        for(int a = 0; a < 6; a++){
            Count = Count + ContentInformation.ChildCounts[a];
        }

        Count = Count * 2;
        int[] Bubble = new int [Count];
        Debug.Log(Count);

        /*
        for(int i = 0; i < Time.Length; i++){
            for(int j = 0; j < Time[i].Length; j++){
                Bubble[b] = Time[i][j][0];
                Bubble[b + 1] = Time[i][j][1];
                if(b < Count - 2){
                    b += 2;
                }
            }
        }
        */

        for(int i = 0; i < Time.Length; i++){
            for(int j = 0; j < Time[i].Length; j++){
                for(int k = 0; k < 2; k++){
                    b = Time[i].Length;
                    Bubble[i * Time[i].Length + j] = Time[i][j][k];
                    Debug.Log(Bubble[b]);
                    b++;
                }
            }
        }

        for(int c = 0; c < Count - 1; c++){
            Debug.Log(c.ToString() + ":" + Bubble[c].ToString());
        }

        int Temp;

        for(int k = 0; k < Count - 1; k++){
            for(int l = Count - 1; l > k; l--){
                if(Bubble[l - 1] > Bubble[l]){
                    Temp = Bubble[l - 1];
                    Bubble[l - 1] = Bubble[l];
                    Bubble[l] = Temp;
                }
            }
        }

        for(int c = 0; c < Count - 1; c++){
            Debug.Log(Bubble[c]);
        }
        

    }
}
