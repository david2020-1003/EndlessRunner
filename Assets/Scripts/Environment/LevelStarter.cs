using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource CountDownFx;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        countDown3.SetActive(true);
        CountDownFx.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        PlayerMove.canMove  = true; 
    }
 
}