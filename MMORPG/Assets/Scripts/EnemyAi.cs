using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
    public GameObject target;
    public float attackTime;
    public float coolDown;
    


    void Start () {
        attackTime = 0;
        coolDown = 2.0f;
            GameObject go = GameObject.FindGameObjectWithTag("Player");
        
        target = go.transform;
    
        maxdistance = 2;
    }
    

    void Update () {
        if(attackTime > 0)
            attackTime -= Time.deltaTime;
        
        if(attackTime < 0)
            attackTime = 0;
        
        
    if(attackTime == 0) {
        Attack();
        attackTime = coolDown;
        }
        Debug.DrawLine(target.position, myTransform.position, Color.red); 
        


        

        myTransform****tation = Quaternion.Slerp(myTransform****tation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
        
        if(Vector3.Distance(target.position, myTransform.position) > maxdistance){
        //Move towards target
        myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
    
        }
    }
    
y     private void Attack() {
        float distance = Vector3.Distance(target.transform.position, transform.position);
        
        
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float direction = Vector3.Dot(dir, transform.forward);
        
                
        if(distance < 2.5f) {
            if(direction > 0) { 
        PlayerHealth eh = (PlayerHealth)target.GetComponent("PlayerHealth");
        eh.AddjustCurrentHealth(-10);
            }
        }
    }
}