using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportInTanel : MonoBehaviour

{
    public int d;
    public GameObject a;
    public GameObject camera;
    /*public void Awake(){
        StenyAndProhody = GetComponent<StenyAndProhody>();
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int go(int o,int t){
        if (o==22){
            for(int i=0;i<6;i++){
                if(StenyAndProhody.arr[i,d]==22){
                    StenyAndProhody.arr[i,d]=StenyAndProhody.arr[i,d]+10;
                    Debug.Log("t2");
                    return 0;
                }
            }
        }
        if (o==88){//выяснить почему если arr[0,5]==13 не прибовляет 88+10?
             for(int i=0;i<6;i++){
                if(StenyAndProhody.arr[i,d]==88){
                    StenyAndProhody.arr[i,d]=StenyAndProhody.arr[i,d]+10;
                    Debug.Log("t88");
                    return 0;
                }
            }

        }
        if (o==66){
             for(int i=0;i<6;i++){
                if(StenyAndProhody.arr[i,d]==66){
                    StenyAndProhody.arr[i,d]=StenyAndProhody.arr[i,d]+10;
                    Debug.Log("t66");
                    return 0;
                }
            }

        }
        if (o==44){
             for(int i=0;i<6;i++){
                
                if(StenyAndProhody.arr[i,d]==44){
                    
                    StenyAndProhody.arr[i,d]=StenyAndProhody.arr[i,d]+10;
                   Debug.Log("t44");
                    return 0;
                }
            }
        }

        return 0;
    }
    void OnTriggerStay (Collider other)
    {
        if ((other.gameObject.name == "Player")&(Input.GetKey(KeyCode.R)))
        {
            if (StenyAndProhody.arr[0,1]==11){
                for (int i=1;i<6;i++){
                    if(StenyAndProhody.arr[i,1]>0){
                        StenyAndProhody.arr[i,1]=StenyAndProhody.arr[i,1]+10;
                    }
                    
                }
            }else{//
            //обозвать их  88 22 66 44 соответственно вверх низ право лево
                for(int i=0;i<6;i++){
                    if(StenyAndProhody.arr[0,i]>10){
                        d=StenyAndProhody.arr[0,i]-10;
                    }
                }
                //Debug.Log(this.gameObject.name[5]);
                Debug.Log(d);
                
                
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
            camera.transform.position = a.transform.position;

        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
