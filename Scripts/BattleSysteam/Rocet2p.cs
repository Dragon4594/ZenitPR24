using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocet2p : MonoBehaviour
{
    public GameObject Zar2p;///обьект боеголовки
    //public GameObject Vec;
    public float reloadp=0;
    public float a =0;
    private GameObject EmptyRocket;
    void OnTriggerStay (Collider other){
        if ((other.gameObject.name!="Player")){
            
            Vector3 direction = GameObject.Find("PoitPric").transform.position - this.transform.position;
            this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
            this.transform.position =   GameObject.Find("Player").transform.position;
            if ((reloadp<=0)&(Input.GetMouseButtonDown(0))){
                reloadp=3.0f;
                 // Vector3 direction = GameObject.Find("w").transform.position - this.transform.position;//w  возможно надо переименовать на карте может быть два w 
                
                EmptyRocket = Instantiate(Zar2p,GameObject.Find("spavnRoccket").transform.position,Quaternion.Euler(0,270,0)); //сделать поворрот на w от обьекта камеры
                Vector3 directionn = GameObject.Find("PoitPric").transform.position - EmptyRocket.transform.position;
                EmptyRocket.transform.rotation = Quaternion.LookRotation(directionn, Vector3.up);
                EmptyRocket.name="EmptyRocket";
                //a=GameObject.Find("PlayerCamera").transform.eulerAngles.y;
                //EmptyRocket.transform.Rotate(a*new Vector3(0,1,0));
                
            }
          
        }

        
    }
    void OnTriggerExit(Collider other){
        if ((other.gameObject.name!="Player")){
            
            Vector3 direction = GameObject.Find("PoitPric").transform.position - this.transform.position;
            this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
            this.transform.position =   GameObject.Find("Player").transform.position;}

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((reloadp<=3.0)&(reloadp>=-0.1)){
            reloadp=reloadp-Time.deltaTime;
        }
        
        
    }
}
