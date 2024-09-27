using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_contr : MonoBehaviour
{
    public float speed = 5.0f;
    public float stamin1 = 100.0f;
    public Transform s;
    public Transform w;
    public Transform a;
    public Transform d;
    public Transform wd;
    public Transform wa;
    public Transform sd;
    public Transform sa;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetInp();
    }
    private void GetInp()
    {
        /*if ((Input.GetKeyDown(KeyCode.X)) && (stamin1 != 0))  ///������ ���� ����
        {
            speed = 7.0f;
        }
        if ((Input.GetKey(KeyCode.X)) && !(stamin1 <= 0))  ///������ ���� ����
        {
            stamin1 = stamin1 - (Time.deltaTime *5) ;
            
        }
        if ((Input.GetKeyUp(KeyCode.X)) || (stamin1 <= 0)) ///������ ���� ����
        {
            speed = 5.0f;
        }
        if ((stamin1 < 100) )
        {
            stamin1 = stamin1 + (Time.deltaTime*5)  ;
        }*/


        if (Input.GetKey(KeyCode.W))
        {
            
            //this1.transform.rotation = Quaternion.Euler(0f,90f,0f);
            //this1.Rotate(g*new Vector3(0,1,0));
            if ((Input.GetKey(KeyCode.D))||(Input.GetKey(KeyCode.A))){
                
                if (Input.GetKey(KeyCode.D)){
                    Vector3 direction = wd.transform.position - this.transform.position;
                    this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                }
                if (Input.GetKey(KeyCode.A)){
                    Vector3 direction = wa.transform.position - this.transform.position;
                    this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                }

                transform.localPosition += transform.forward * (speed/2) * Time.deltaTime;
            }
            else{
                Vector3 direction = w.transform.position - this.transform.position;
                this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            } 
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.S))
        {
            
            
            if ((Input.GetKey(KeyCode.D))||(Input.GetKey(KeyCode.A))){
                if (Input.GetKey(KeyCode.D)){
                    Vector3 direction = sd.transform.position - this.transform.position;
                    this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                }
                if (Input.GetKey(KeyCode.A)){
                    Vector3 direction = sa.transform.position - this.transform.position;
                    this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                }
                transform.localPosition += transform.forward * (speed/2) * Time.deltaTime;
            }
            else{
                Vector3 direction = s.transform.position - this.transform.position;
                this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.A))
            
        {
            //transform.localPosition += -transform.right * speed * Time.deltaTime;
            if ((Input.GetKey(KeyCode.W))||(Input.GetKey(KeyCode.S))){
                if (Input.GetKey(KeyCode.W)){
                    Vector3 direction = wa.transform.position - this.transform.position;
                    this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                }
                if (Input.GetKey(KeyCode.S)){
                    Vector3 direction = sa.transform.position - this.transform.position;
                    this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                }
                transform.localPosition += transform.forward * (speed/2) * Time.deltaTime;
            }
            else{
                Vector3 direction = a.transform.position - this.transform.position;
                this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            //transform.localPosition += transform.right * speed * Time.deltaTime;
            if ((Input.GetKey(KeyCode.W))||(Input.GetKey(KeyCode.S))){
                if (Input.GetKey(KeyCode.W)){
                    Vector3 direction = wd.transform.position - this.transform.position;
                    this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                }
                if (Input.GetKey(KeyCode.S)){
                    Vector3 direction = sd.transform.position - this.transform.position;
                    this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                }
                transform.localPosition += transform.forward * (speed/2) * Time.deltaTime;

            }
            else{
                Vector3 direction = d.transform.position - this.transform.position;
                this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }
        }

    }
}
