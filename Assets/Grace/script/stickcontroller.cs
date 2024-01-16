/*
 * Author: Grace Foo
 * Date: 16/1/2024
 * Description: Code for the stick model
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickcontroller : MonoBehaviour
{
    public AudioSource rightSound;
    public AudioSource wrongSound;

    public GameObject correct1;
    public GameObject wrong1;
    public GameObject stick1;
    public GameObject qn1;
    public GameObject models1;
    public GameObject bonus1;

    public GameObject correct2;
    public GameObject wrong2;
    public GameObject stick2;
    public GameObject qn2;
    public GameObject models2;
    public GameObject bonus2;

    public GameObject correct3;
    public GameObject wrong3;
    public GameObject stick3;
    public GameObject qn3;
    public GameObject models3;
    public GameObject bonus3;

    public GameObject correct4;
    public GameObject wrong4;
    public GameObject stick4;
    public GameObject qn4;
    public GameObject models4;
    public GameObject bonus4;

    public GameObject correct5;
    public GameObject wrong5;
    public GameObject stick5;
    public GameObject qn5;
    public GameObject models5;
    public GameObject bonus5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("qn1c"))
        {
            bonus1.gameObject.SetActive(true);
            correct1.gameObject.SetActive(true);
            stick1.gameObject.SetActive(false);
            qn1.gameObject.SetActive(false);
            models1.gameObject.SetActive(false);
            rightSound.Play();
        }

        if (other.gameObject.CompareTag("qn1w"))
        {
            wrong1.gameObject.SetActive(true);
            stick1.gameObject.SetActive(false);
            qn1.gameObject.SetActive(false);
            models1.gameObject.SetActive(false);
            wrongSound.Play();

        }
    }

}
