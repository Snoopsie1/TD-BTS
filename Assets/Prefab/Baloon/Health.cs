using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
     public float max_health =100f;
    public float cur_health;


    // Start is called before the first frame update
    void Start()
    {
       
        cur_health = max_health;
        
    }
    public void TakeDamag(float amount)
    {
        //hvis det er alive er false returnere du bare take dmg
        cur_health -= amount;
        //Checkker om du er i live eller ej og deaktivere 
        if(cur_health <=0){
            gameObject.SetActive(false);
        }
        
    } 

    // Update is called once per frame

//    public void setHealth(){
//         float my_health = cur_health/ max_health;
//     }
}
