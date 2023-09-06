using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }   
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.RotateAround(transform.position, -Vector3.up, rotateSpeed * Time.deltaTime);
        }  
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));
        }
    }
}
