using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    Game game;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���������� ����������");
        game = new Game();
        text = GameObject.Find("GameAnswer").GetComponent<Text>();
        //answerRock.transform.position = new Vector3(3, 3, 0);
        //trigger = answerRock.GetComponent<Event>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(trigger.clickCount);
    }

    public void SetAnswer(string answer)
    {
        Debug.Log("received answer: " + answer);
        GameResponse roundResult = game.PlayRound(answer);
        Debug.Log(roundResult);
        text.text =
            "����� ������: " + roundResult.roundNumber + "\n"
            + "����� ������: " + roundResult.playerAnswer + "\n"
            + "����� ����: " + roundResult.botAnswer + "\n"
            + "����: " + roundResult.gameResult;
    }
}
