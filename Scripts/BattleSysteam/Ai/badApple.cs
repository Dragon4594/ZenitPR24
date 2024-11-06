using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class badApple : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent badApple1;
    public float LookRad;
    
    // Start is called before the first frame update
    void Start()
    {
        badApple1= GetComponent<NavMeshAgent>();
        target = dopBadApple.instance.playerDopBedApple.transform;    
    }
    void LookTarget(){
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x,0,direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime);
        }
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position,transform.position);
        if (distance<=LookRad){
            badApple1.SetDestination(target.position);
            if(distance<=badApple1.stoppingDistance){
                LookTarget();
            }
        }
    }
}
