using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportInTanel : MonoBehaviour

{
    public int d;
    public GameObject a;
    public GameObject camera;
    public float f=0;
    /*public void Awake(){
        StenyAndProhody = GetComponent<StenyAndProhody>();
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int go(int o,int t){
        if (o==22){
            for(int i=0;i<7;i++){
                if(StenyAndProhody.arr[i,d]==22){
                    StenyAndProhody.arr[i,d]=StenyAndProhody.arr[i,d]+10;
                    //Debug.Log("t2");
                    return 0;
                }
            }
        }
        if (o==88){//выяснить почему если arr[0,5]==13 не прибовляет 88+10?
                //Debug.Log(d);
             for(int i=0;i<7;i++){
                //Debug.Log(StenyAndProhody.arr[i,d]);
                if(StenyAndProhody.arr[i,d]==88){
                    StenyAndProhody.arr[i,d]=StenyAndProhody.arr[i,d]+10;
                    
                    return 0;
                }
            }

        }
        if (o==66){
             for(int i=0;i<7;i++){
                if(StenyAndProhody.arr[i,d]==66){
                    StenyAndProhody.arr[i,d]=StenyAndProhody.arr[i,d]+10;
                    //Debug.Log("t66");
                    return 0;
                }
            }

        }
        if (o==44){
             for(int i=0;i<7;i++){
                
                if(StenyAndProhody.arr[i,d]==44){
                    
                    StenyAndProhody.arr[i,d]=StenyAndProhody.arr[i,d]+10;
                  
                    return 0;
                }
            }
        }

        return 0;
    }
    void OnTriggerStay (Collider other)
    {
        if ((other.gameObject.name=="Player")&(Input.GetKey(KeyCode.R))){
                f=f+Time.deltaTime;
        }
        if((f>=3.0)&(other.gameObject.name=="Player")){
            
       if (StenyAndProhody.arr[0,1]==11){
                for (int i=1;i<7;i++){
                    if(StenyAndProhody.arr[i,1]>0){
                        StenyAndProhody.arr[i,1]=StenyAndProhody.arr[i,1]+10;
                    }
                    
                }
            }else{//
            //обозвать их  88 22 66 44 соответственно вверх низ право лево
                for(int i=0;i<7;i++){
                    if(StenyAndProhody.arr[0,i]>10){
                        //d=StenyAndProhody.arr[0,i]-10;
                        d=i;
                    }
                }
                //Debug.Log(this.gameObject.name[5]);
                //Debug.Log(d);
                 
                if (this.gameObject.name == "Emty22"){
                    go(22,d);
                }
                if (this.gameObject.name == "Emty88"){
                    go(88,d);
                }
                if (this.gameObject.name == "Emty44"){
                    go(44,d);
                     
                }
                if (this.gameObject.name == "Emty66"){
                    go(66,d);
                }
                
            }
            other.transform.position = a.transform.position;
            other.transform.rotation = Quaternion.Euler(0,180,0);
            camera.transform.rotation = Quaternion.Euler(0,180,0);
    }
    }
    
    // Update is called once per frame
    void Update()
    {
        if(f>0){
            f=f+Time.deltaTime*2;
        }
        if (f>=3.1){
            f=0;
        }
    }
        
}
