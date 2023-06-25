using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlScore : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;

    public GameObject textScore1;
    public GameObject textScore2;

    public int goalToWin;

    private void Update()
    {
        if(this.player1Score >= goalToWin || this.player2Score >= goalToWin) 
        {
            print("Game won");
        }
    }

    private void FixedUpdate()
    {
        Text tagScore1 = this.textScore1.GetComponent<Text>();
        tagScore1.text = this.player1Score.ToString();

        Text tagScore2 = this.textScore2.GetComponent<Text>();
        tagScore2.text = this.player2Score.ToString();
    }
    public void GoalPlayer1()
    {
        player1Score++;
    }

    public void GoalPlayer2()
    {
        player2Score++;
    }
    //public void GoalPlayer(int player)
    //{
    //    player++;
    //}
}
