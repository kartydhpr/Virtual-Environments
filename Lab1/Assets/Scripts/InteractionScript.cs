using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    public Transform user;
    public Transform object1;
    public float distToObject1;
    public string textInfo1 = "You're on fire!";
    public Texture aTextrure;
    public AudioSource audioSource;
    public AudioClip mySound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        distToObject1 = Vector3.Distance(user.position, object1.position);
        if(distToObject1 < 2)
        {
            audioSource.PlayOneShot(mySound);
        }
        else
        {
            audioSource.Stop();
        }
    }

    void OnGUI()
    {
        if (distToObject1 < 1)
        {
            textInfo1 = GUI.TextArea(new Rect(10, 10, 200, 100), textInfo1, 100);
        }

        if (distToObject1 < 1)
        {
            GUI.DrawTexture(new Rect(200, 10, 300, 600), aTextrure, ScaleMode.StretchToFill, true, 10.0F);
        }

    }
}
