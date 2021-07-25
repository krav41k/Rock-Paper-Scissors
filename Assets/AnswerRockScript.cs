using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerRockScript : MonoBehaviour, IPointerClickHandler
{

    Controller ControllScript;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("нажатие зарегистрировано");

        sendAnswer("камень");
    }



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Камень загрузился");
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
