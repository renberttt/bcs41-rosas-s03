using Godot;

public class Ball : Area2D
{
    private float speed = 200;
    public Vector2 direction = Vector2.Left;
    private Vector2 initialPosition;
    public override void _Ready()
    {
        initialPosition = Position;
    }
    public override void _Process(float delta)
    {
        speed += delta * 2;
        Position += speed * delta * direction;
    }

    public void Reset(int scoringPlayer)
    {
        Position = initialPosition;
        if (scoringPlayer == 1)
        {
            direction = Vector2.Right;
        }
        else if (scoringPlayer == 2)
        {
            direction = Vector2.Left;
        }
    }

    public void Bounce(Vector2 hitAngle)
    {
        direction = direction.Bounce(hitAngle);
    }
}
