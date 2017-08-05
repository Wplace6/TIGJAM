using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [Tooltip("How long the game lasts, as a whole number")]
    public int breathLength = 45;
    public GameObject BlackScreenPanel;

    public bool IsDead = false;
    private bool UpdateStopper = true;
    public GameObject playerObj;
    public Animation anim;

    //public Vector3 startPosition = new Vector3(0,0,0);

    // Update is called once per frame
    void Update ()
    {
        
        if(playerObj.transform.position.x != 0 && playerObj.transform.position.z != 0 && IsDead == false && UpdateStopper == true)
        {
            StartCoroutine(Example());
        }

        if (IsDead == true && UpdateStopper == true)
        {
            StartCoroutine(Fading());
            UpdateStopper = false;
        }

    }

  
    IEnumerator Example()
    {
        if (IsDead == false && UpdateStopper == true)
        {
            yield return new WaitForSeconds(breathLength);
            //Debug.Log("You're Dead");
            IsDead = true;
        }

    }

    IEnumerator Fading()
    {
        if (IsDead == true && UpdateStopper == true)
        {
            anim = BlackScreenPanel.GetComponent<Animation>();
            anim.Play();
            Debug.Log("fading anim should be playing");
            UpdateStopper = false;
            yield return new WaitForSeconds(6);
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
