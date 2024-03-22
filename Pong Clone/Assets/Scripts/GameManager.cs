
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text playerscore;
    public Text computerscore;

    private int playerScore;
    private int computerScore;
    public Ball ball; //Ball sinifindan bir obje yaratiyoruz.
    public void PlayerScores()
    {
        
        playerScore++;
        playerscore.text = playerScore.ToString();
        ball.ResetPosition();//biz skor yaptigimiz zaman topun konumu sifirlanacak.
    }
    public void ComputerScores()
    {

        
        computerScore++;
        computerscore.text = computerScore.ToString();
        ball.ResetPosition();
    }
}
