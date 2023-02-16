using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catch_food : MonoBehaviour
{
    public game_controller myGameController;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.StartsWith("fruit"))
        {
         //   myAudioSource.PlayOneShot(addPointsSound, .8f);
            Destroy(other.gameObject);
            myGameController.addPoints();

        }
        if (other.gameObject.name.StartsWith("junk"))
        {
         //   myAudioSource.PlayOneShot(loseLifeSound, .8f);
            Destroy(other.gameObject);
            myGameController.subtractLife();

        }
        if (other.gameObject.name.StartsWith("power_paste"))
        {
         //   myAudioSource.PlayOneShot(gainLifeSound, .8f);
            Destroy(other.gameObject);
            myGameController.gainLife();
        }
    }
}
