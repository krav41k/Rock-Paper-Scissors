using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class GameResponse
{
    public string playerAnswer;
    public string botAnswer;
    public string gameResult;
    public int roundNumber;

    public GameResponse(string playerAns, string botAns, string gameResult, int round)
    {
        this.playerAnswer = playerAns;
        this.botAnswer = botAns;
        this.gameResult = gameResult;
        this.roundNumber = round;
    }
}

class Game
{
    int botScore = 0;
    int playerScore = 0;
    int draw = 0;


    public int round = 0;

    static Game()
    {

    }


    public void StartGame()
    {
        //while (true)
        //{
        //    if (!PlayRound())
        //    {
        //        break;
        //    }
        //}


        EndGame();
    }

    public void EndGame()
    {

    }

    public GameResponse PlayRound(string playerAnswer)
    {

        round++;

        int value = Random.Range(0, 3);

        string botAnswer = "";

        switch (value)
        {
            case 0:
                botAnswer = "������";
                break;

            case 1:
                botAnswer = "�������";
                break;

            case 2:
                botAnswer = "������";
                break;
        }


        if (("������" == playerAnswer && "������" == botAnswer) || ("�������" == playerAnswer && "������" == botAnswer) || ("������" == playerAnswer && "�������" == botAnswer)) // ������� ������ ������
        {
            playerScore++;
            return new GameResponse(playerAnswer, botAnswer, "����� �������", round);
        }
        else if (playerAnswer == botAnswer)  // ������� �����
        {
            draw++;
            return new GameResponse(playerAnswer, botAnswer, "�����", round);
        }
        else // ���������� ������� ������ ����
        {
            botScore++;
            return new GameResponse(playerAnswer, botAnswer, "����� ��������", round);
        }
    }
}
