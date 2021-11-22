using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightChange : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField]public Dropdown dropdown;
    public string[] ObjectName = {"splight","ss1","ss2","ss3","ss4",
    "hl1","hl2","hl3","hl4","hl5","hh1","hh2","hh3","hh4","hh5",
    "PinSpotLight","frl1","frl2","frl3","frl4","frr1","frr2","frr3","frr4",
    "cl1","cl2","cl3","cl4","cl5","cl6","cl7","cl8","cl9","cl10","cl11","cl12","cl13"};

    public GameObject[] Object = new GameObject[37];
  
    void Start()
    {
        for(int i = 0; i < 37; i++){
            Object[i] = GameObject.Find(ObjectName[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(dropdown.value == 0){
            for(int i = 0; i < 37; i++){
                if(i == 0){
                Object[i].GetComponent<Spotlightkouryou>().enabled = false;
                }else if(i > 4 && i < 15){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i == 15){
                    Object[i].GetComponent<MoveSpotLight>().enabled = false;
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i > 15 && i < 37){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                }
            }
            for(int i = 1; i < 5; i++){
                Object[i].GetComponent<SasuKouryou>().enabled = true;
            }
            //script.enabled = false;
        }else if(dropdown.value == 1){
            for(int i = 0; i < 37; i++){
                if(i > 0 && i < 5){
                    Object[i].GetComponent<SasuKouryou>().enabled = false;
                }else if(i > 4 && i < 15){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i == 15){
                    Object[i].GetComponent<MoveSpotLight>().enabled = false;
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i > 15 && i < 37){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                }
            }
            Object[0].GetComponent<Spotlightkouryou>().enabled = true;
        }else if(dropdown.value == 2){
            for(int i = 0; i < 37; i++){
                if(i == 0){
                Object[i].GetComponent<Spotlightkouryou>().enabled = false;
                }else if(i > 0 && i < 5){
                    Object[i].GetComponent<SasuKouryou>().enabled = false;
                }else if(i > 15 && i < 37){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                }
            }
            Object[15].GetComponent<MoveSpotLight>().enabled = true;
            Object[15].GetComponent<Kouryou>().enabled = true;
            Object[15].GetComponent<ColorChange>().enabled = true;
        }else if(dropdown.value == 3){
            for(int i = 0; i < 37; i++){
                if(i == 0){
                Object[i].GetComponent<Spotlightkouryou>().enabled = false;
                }else if(i > 0 && i < 5){
                    Object[i].GetComponent<SasuKouryou>().enabled = false;
                }else if(i == 15){
                    Object[i].GetComponent<MoveSpotLight>().enabled = false;
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i > 15 && i < 37){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                }
            }
            for(int i = 5; i < 15; i++){
                Object[i].GetComponent<Kouryou>().enabled = true;
                Object[i].GetComponent<ColorChange>().enabled = true;
            }
        }else if(dropdown.value == 4){
            for(int i = 0; i < 37; i++){
                if(i == 0){
                Object[i].GetComponent<Spotlightkouryou>().enabled = false;
                }else if(i > 0 && i < 5){
                    Object[i].GetComponent<SasuKouryou>().enabled = false;
                }else if(i > 4 && i < 15){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i == 15){
                    Object[i].GetComponent<MoveSpotLight>().enabled = false;
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i > 15 && i < 24){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                }
            }
            for(int i = 24; i < 37; i++){
                Object[i].GetComponent<Kouryou>().enabled = true;
            }
        }else if(dropdown.value == 5){
            for(int i = 0; i < 37; i++){
                if(i == 0){
                Object[i].GetComponent<Spotlightkouryou>().enabled = false;
                }else if(i > 0 && i < 5){
                    Object[i].GetComponent<SasuKouryou>().enabled = false;
                }else if(i > 4 && i < 15){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i == 15){
                    Object[i].GetComponent<MoveSpotLight>().enabled = false;
                    Object[i].GetComponent<Kouryou>().enabled = false;
                    Object[i].GetComponent<ColorChange>().enabled = false;
                }else if(i > 26 && i < 37){
                    Object[i].GetComponent<Kouryou>().enabled = false;
                }
            }
            for(int i = 16; i < 24; i++){
                Object[i].GetComponent<Kouryou>().enabled = true;
            }
        }
    }

}
