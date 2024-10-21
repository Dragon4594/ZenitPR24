using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Nazad : MonoBehaviour
{
    public GameObject a;
    public int u = StenyAndProhody.a;
    public StenyAndProhody StenyAndProhody;
    /*public void Awake(){
        StenyAndProhody = GetComponent<StenyAndProhody>();
        
        
    }*/
    
    // Start is called before the first frame update
    void OnTriggerStay(Collider other){
        if(other.gameObject.name == "Player"){
            if (StenyAndProhody.arr[0,1]==11){
                StenyAndProhody.arr[2,1]=88;
                a.transform.position=GameObject.Find("dortriger").transform.position;
            }
            for(int i = 0; i<u;i++){
                if (StenyAndProhody.arr[0,i]>10){
                    for(int t =0;t<u;t++){
                        if (StenyAndProhody.arr[t,i]==98){
                            StenyAndProhody.arr[t,i]=88;
                            a.transform.position=GameObject.Find("Emty88").transform.position;
                        }
                        if (StenyAndProhody.arr[t,i]==54){
                            StenyAndProhody.arr[t,i]=44;
                            a.transform.position=GameObject.Find("Emty44").transform.position;
                        }
                        if (StenyAndProhody.arr[t,i]==76){
                            StenyAndProhody.arr[t,i]=66;
                            a.transform.position=GameObject.Find("Emty66").transform.position;
                        }
                        if (StenyAndProhody.arr[t,i]==32){
                            StenyAndProhody.arr[t,i]=22;
                            a.transform.position=GameObject.Find("Emty22").transform.position;
                        }
                }
            }
            
        }
    }
    }
    void Update(){
       
        }
}
