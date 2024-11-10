using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocetGun1 : MonoBehaviour
{
    public float q=0;
    public GameObject Zar;
    public float speedr=7.0f;//шаманить со скоростью
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerStay (Collider other){
        if(Zar.gameObject.name=="EmptyRocket"){
        if ((other.gameObject.name!="EmptyRocket")){ //в скрипте Rocet2p создоваемый обьект переименовать на имя и вставить это имя вместо RocketLauncherMissle
            q=q+1;
        }
        }
    }
    private bool z=true;
    // Update is called once per frame
    void Update()
    {   
        if(Zar.gameObject.name=="EmptyRocket"){
        if ((Input.GetMouseButtonDown(0))&(z)){//в скрипте Rocet2p создоваемый обьект переименовать в дргое имя
            z=false;
        }
        }
        if((!z)&(q==0)){
            
            Zar.transform.position += transform.forward * (speedr) * Time.deltaTime;
            
        }
        if (q>=1){
          q=q+Time.deltaTime;
        this.transform.localScale=new Vector3(q*0.2f,q,q);  
        }
        if (q>=130){
            q=0;
            Destroy(Zar.gameObject);
            
        }
        
        
    }
}
