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
                botAnswer = "камень";
                break;

            case 1:
                botAnswer = "ножницы";
                break;

            case 2:
                botAnswer = "бумага";
                break;
        }


        if (("бумага" == playerAnswer && "камень" == botAnswer) || ("ножницы" == playerAnswer && "бумага" == botAnswer) || ("камень" == playerAnswer && "ножницы" == botAnswer)) // условие победы игрока
        {
            playerScore++;
            return new GameResponse(playerAnswer, botAnswer, "»грок победил", round);
        }
        else if (playerAnswer == botAnswer)  // условие ничьи
        {
            draw++;
            return new GameResponse(playerAnswer, botAnswer, "Ќичь€", round);
        }
        else // остаточное условие победы бота
        {
            botScore++;
            return new GameResponse(playerAnswer, botAnswer, "»грок проиграл", round);
        }
    }
}
