using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //GameManager class to share info across scripts
    public static GameManager instance;

    public int coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Ensures theres only one instance at a time
        if(instance == null)
        {
            instance = this;
        }

        /*if (instance != this)
            Destroy(gameObject);
        //carries object to next scene
        DontDestroyOnLoad(gameObject);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        
    }
}
