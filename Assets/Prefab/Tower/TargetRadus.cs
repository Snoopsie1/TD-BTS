using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRadus : MonoBehaviour
{
    // Start is called before the first frame update
    //Her er radius der på rangen
   public float detectObjectRadius = 5f;
  
  GameObject Tower;
    // Start is called before the first frame update
   void FixedUpdate() // Fixed update is called at a fixed rate independent of frame rate
    {
        //here is the damge countculator
    
//Here is the the detector that detects, whar comes in radius
        var nearbyColliders = Physics.OverlapSphere(transform.position, detectObjectRadius);
        foreach (Collider col in nearbyColliders)
        {
            if (col.gameObject.tag == "Baloon")
            {
                var cubeRenderer = col.gameObject.GetComponent<Renderer>();
                cubeRenderer.material.SetColor("_Color", Color.green);
            }
        }
    }
    

      void OnDrawGizmos() 
      // This method draws gizmos in the editor (cannot be seen in the Game, only the scene editor!)
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectObjectRadius);
    }
   

}
