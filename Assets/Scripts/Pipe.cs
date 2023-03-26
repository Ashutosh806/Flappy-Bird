using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed;
     
    void Update()
    {
       transform.position += Vector3.left *speed*Time.deltaTime; 
    }
}
