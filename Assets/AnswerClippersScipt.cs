using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerClippersScipt : MonoBehaviour, IPointerClickHandler
{
    Controller ControllScript;

    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("нажатие зарегистрировано");

        sendAnswer("ножници");
    }


    void Start()
    {
        Debug.Log("ножници");
        GameObject controller = GameObject.Find("Contoller");
        ControllScript = controller.GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void sendAnswer(string answer)
    {
        ControllScript.SetAnswer(answer);
    }
}
