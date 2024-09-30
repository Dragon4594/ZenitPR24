using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamp : MonoBehaviour
{
    public GameObject a;
    public GameObject a1;
    public Transform a2;
    public GameObject ylou;
    public GameObject red;
    public Transform platforms;
   public float i=0.0f;
   public bool isGraund;
   public bool T=false;
   public bool T1=false;
   void OnCollisionEnter(){
    isGraund=true;
   }
   
    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKeyDown(KeyCode.Space))&(isGraund==true)){
            //this.transform.position += new Vector3(0,10,0)*Time.deltaTime;
            GetComponent<Rigidbody>().AddForce(new Vector3(0,300,0));
            isGraund=false;
        }
        if (Input.GetKey(KeyCode.E)){
            platforms.transform.position = a2.transform.position;
            a1.SetActive(true);
            
        }
        if (Input.GetKeyUp(KeyCode.E)){
            a1.SetActive(false);
            a.SetActive(true);
            i=i+Time.deltaTime;
        }
        if (i>0.0f){
            i=i+Time.deltaTime;
            if ((i>=2.0)&(i<2.1)){
                T=true;
            }
            if 
            ((i>=4.0)&(i<4.1)){
                T1=true;
            }
        }
        if(T){
            a.SetActive(false);
            ylou.SetActive(true);
            T=false;
        }
        if(T1){
            ylou.SetActive(false);
            red.SetActive(true);
            T1=false;
        }

        if (i>=5.0f){
            i=0.0f;
            red.SetActive(false);
        }
    }
}
