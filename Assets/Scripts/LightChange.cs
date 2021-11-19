using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightChange : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField]public Dropdown dropdown;
    ColorChange script;
    public string[] ObjectName = {"splight", "ss1", "ss2", "ss3", "ss4", 
                            "hl1", "hl2", "hl3", "hl4", "hl5", "hh1", "hh2", 
                            "hh3", "hh4", "hh5", "PinSpotLight", "frl1",
                            "frl2", "frl3", "frl4", "frr1", "frr2", "frr3", "frr4", "cl1", "cl2", 
                            "cl3", "cl4", "cl5", "cl6", "cl7", "cl8", "cl9", "cl10", "cl11", 
                            "cl12", "cl13"};

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
        if(dropdown.value==0){
            for(int i = 0; i < 37;i++){
                if(i > 4){
                Object[i].GetComponent<Kouryou>().enabled = false;
                }
            }
            //script.enabled = false;
        }
    }

}
