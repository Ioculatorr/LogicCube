using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject[] myLight;
    public bool mode = true;

    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            StopAllCoroutines();
            StartCoroutine(LightFromLeft());
        }
        else if(Input.GetKeyDown("2"))
        {
            StopAllCoroutines();
            StartCoroutine(LightFromRight());
        }
    } 
    IEnumerator LightFromLeft()
    {
        yield return new WaitForSeconds(.5f);
        do
        {
            mode = !mode;
            for (int i = 0; i < myLight.Length; i++)
            {
                myLight[i].SetActive(mode);
                yield return new WaitForSeconds(.5f);
            }
        } while (true);
    }
    IEnumerator LightFromRight()
    {
        yield return new WaitForSeconds(.5f);
        do
        {
            mode = !mode;
            for (int i = myLight.Length - 1; i >= 0; i--)
            {
                myLight[i].SetActive(mode);
                yield return new WaitForSeconds(.5f);
            }
        } while (true);
    }
}
