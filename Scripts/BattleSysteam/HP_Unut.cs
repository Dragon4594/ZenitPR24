using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Unut : MonoBehaviour
{
    public GameObject s;
    public int t=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerStay (Collider other){
        if (other.gameObject.name=="Sphere"){//// переиминовать все сферы урона на другое имя
            t=t-1;
        }
        dt();
    }
    void dt(){
        if (t==0){
          // s.SetActive(false); 
          Destroy(s);
        }
        
    }
}
