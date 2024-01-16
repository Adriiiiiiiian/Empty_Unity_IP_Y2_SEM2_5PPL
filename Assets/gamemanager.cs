using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public int gamecount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gamecount == 4)
        {

        }
    }

    public void increaseCount()
    {
        gamecount = gamecount + 1;
    }
}
