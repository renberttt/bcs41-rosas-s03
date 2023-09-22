using Godot;

public class LeftandRight : Area2D
{
    private int player1Score = 0;
    private int player2Score = 0;
    private Label player1ScoreLabel;
    private Label player2ScoreLabel;

    public override void _Ready()
    {
        player1ScoreLabel = GetNode<Label>("Label");
        player2ScoreLabel = GetNode<Label>("Label2");
    }

    public void OnWallAreaEntered(Area2D area)
    {
        if (area is Ball ball)
        {
            if (Position.x < 0)
            {
                player2Score++;
                player2ScoreLabel.Text = "Score: " + player2Score.ToString();
                ball.Reset(2);
            }
            else if (Position.x > 0)
            {
                player1Score++;
                player1ScoreLabel.Text = "Score: " + player1Score.ToString();   
                ball.Reset(1);
            }
        }
    }
}
