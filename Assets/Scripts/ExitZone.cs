using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Plater"){
            LevelManager.sharedInstance.AddLevelBlock();
            LevelManager.sharedInstance.RemoveLevelBlock();
        }
    }
}
