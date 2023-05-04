using UnityEngine;

public class PrzyciskSkrypt : MonoBehaviour
{
    public GameObject cubeObject;
    public GameObject eButton;
    private bool isCursorOnObject = false;
    private bool ttt;
    void Update()
    {
        if (isCursorOnObject && Input.GetKeyDown(KeyCode.E))
        {
            var ttt = cubeObject.GetComponent<AnimationCurveController>().enabled;
            if (ttt == false) 

            {
                cubeObject.GetComponent<AnimationCurveController>().enabled = true;           
            }
            else
            {
                cubeObject.GetComponent<AnimationCurveController>().enabled = false;
            }

        }
    }
    void OnMouseEnter()
    {
        isCursorOnObject = true;
        eButton.SetActive(true); 
    }
    void OnMouseExit()
    {
        isCursorOnObject = false;
        //eButton.SetActive(false); 
    }
    
}
//cubeObject.transform.Translate(Vector3.up * 2f); //uruchomienie innego skryptu na obiekcie