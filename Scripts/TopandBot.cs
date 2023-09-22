using Godot;

public class TopandBot : Area2D
{
    [Export]
    private int bounce = 1;
    public void OnAreaEntered(Area2D area)
    {
        if (area is Ball ball)
        {
            ball.direction = (ball.direction + new Vector2(0,bounce)).Normalized();
        }
    }
}