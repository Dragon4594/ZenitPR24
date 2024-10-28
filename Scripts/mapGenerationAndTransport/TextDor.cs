using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDor : MonoBehaviour
{
    public GameObject textE;
    public GameObject cirkl;
    
    public float i;
    public static float q=0;
    public static int tanel=0;
    public static int steny=0;
    public static int nazad=0;
    // Start is called before the first frame update
    public void OnTriggerStay (Collider other){
        if(other.gameObject.name=="Player"){
            textE.SetActive(true);
            
        }
        if ((other.gameObject.name=="Player") & (Input.GetKey(KeyCode.R))){
            cirkl.SetActive(true);
            i=i+Time.deltaTime;
            
        }
        
    }
    public void OnTriggerExit (Collider other){
        if(other.gameObject.name=="Player"){
            textE.SetActive(false);
            

        }
    }
    void Start(){
        i=0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((i>0)&(i<=3.1)){
            i=i+Time.deltaTime*2;
            cirkl.transform.localScale=new Vector3(i,i,0);
        }
        if (i>=3){
            q=i;
            i=0;
            /*if((this.gameObject.name=="dortriger")||(this.gameObject.name=="Emty22")||(this.gameObject.name=="Emty44")||(this.gameObject.name=="Emty66")||(this.gameObject.name=="Emty88")){
                tanel=1;
                
            }
            if ((this.gameObject.name=="TrigerTeleportNextRum")){
                steny=1;

            }
            if (this.gameObject.name=="TrigerTeleportNazad"){
                nazad=1;

            }*/
            
            
        }
        
        
        if ((q<=3.1)&(q>=0.01)){
            
            q=q-Time.deltaTime*2;
            cirkl.transform.localScale=new Vector3(q,q,0);
        }
        if (q<=0.01){
            q=0;
            
        }
        /*if ((q==0)&(i==0)){
            cirkl.transform.localScale=new Vector3(0,0,0);
        }*/
    }
}
