using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Nazad : MonoBehaviour
{
    public GameObject a;
    public StenyAndProhody StenyAndProhody;
    public void Awake(){
        StenyAndProhody = GetComponent<StenyAndProhody>();
        
        
    }
    
    // Start is called before the first frame update
    void OnTriggerStay(Collider other){
        /*if(other.GameObject.name=="Play"){
            PlayerPrefs.GetInt("rumn")
        }*/
    }
    void Update(){
        /*Debug.Log(StenyAndProhody.arr[1,2]==22);
        if(StenyAndProhody.arr[1,2]==22){
            Debug.Log("yes");
        }
        if (StenyAndProhody.arr[1,2]==22){
            a.SetActive(false);
        }*/
        }
}
