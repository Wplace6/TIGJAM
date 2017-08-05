using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    [Tooltip("How long the game lasts, as a whole number")]
    public int breathLength = 45;

    public GameObject playerObj;
    //public Vector3 startPosition = new Vector3(0,0,0);
	
	// Update is called once per frame
	void Update ()
    {

        if(playerObj.transform.position.x != 0 && playerObj.transform.position.z != 0)
        {
            StartCoroutine(Example());
        }
		//if(player position != origin) {alarm[0] = 1 second}

        //if(alarm[0]) {timeLength += ; reset alarm[0]}

        //if(breathLength <= timeLength){kill the player}

	}

  
    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(breathLength);
        print("You're Dead");
    }
}
