using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [Tooltip("How long the game lasts, as a whole number")]
    public int breathLength = 45;
    public GameObject BlackScreen;
    public Color BlackScreenColor = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    public Color ClearScreenColor = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    public float fadetime;
    public bool IsDead = false;
    public GameObject playerObj;

    //public Vector3 startPosition = new Vector3(0,0,0);

    // Update is called once per frame
    void Start ()
    {
        Image img = BlackScreen.GetComponent<Image>();
        img.color = ClearScreenColor;

    }

    void Update ()
    {
        
        if(playerObj.transform.position.x != 0 && playerObj.transform.position.z != 0)
        {
            StartCoroutine(Example());
        }
        //if(player position != origin) {alarm[0] = 1 second}

        //if(alarm[0]) {timeLength += ; reset alarm[0]}

        //if(breathLength <= timeLength){kill the player}

        if (IsDead == true)
        {
            Image img = BlackScreen.GetComponent<Image>();
            img.color = Color.Lerp(ClearScreenColor, BlackScreenColor, fadetime);
            StartCoroutine(Restart());
        }

	}

  
    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(breathLength);
        print("You're Dead");
        IsDead = true;
        
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel(Application.loadedLevel);
    }
}
