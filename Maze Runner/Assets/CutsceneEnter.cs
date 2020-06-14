using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneEnter : MonoBehaviour
{
    public GameObject Sword;
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    private void OnTriggerEnter(Collider other)
    {
        PlayableDirector pd = Sword.GetComponent<PlayableDirector>();
        if(pd != null)
        {
            pd.Play();
        }

        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(15);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);

    }

}

