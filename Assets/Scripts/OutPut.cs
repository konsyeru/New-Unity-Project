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

}
