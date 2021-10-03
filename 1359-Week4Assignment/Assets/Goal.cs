using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    //used to go to specific level
    [SerializeField]
    int goToLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.coins == 4)
        {
            SceneManager.LoadScene(goToLevel);
            GameManager.instance.coins = 0;
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        //Loads scene after the one currently in
        if (GameManager.instance.coins == 4)
        {
            SceneManager.LoadScene("Level2");
        }
        
    }*/


}
