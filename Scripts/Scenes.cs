using Godot;
using System;

public class Scenes : Area2D
{
    private int pingpong;
    [Export]
    public int playerNumber;
    public override void _Process(float delta)
    {
        float amount = 0.5f;
        if (playerNumber == 1)
        {
            if (Input.IsKeyPressed((int)KeyList.W))
            {
                this.Position += new Vector2(0, -amount);
            }
            if (Input.IsKeyPressed((int)KeyList.S))
            {
                this.Position += new Vector2(0, amount);
            }
        }
        else if (playerNumber == 2)
        {
            if (Input.IsKeyPressed((int)KeyList.Up))
            {
                this.Position += new Vector2(0, -amount);
            }
            if (Input.IsKeyPressed((int)KeyList.Down))
            {
                this.Position += new Vector2(0, amount);
            }
        }
    }

    public void OnAreaEntered(Area2D area)
    {
        if (area is Ball ball)
        {
            Vector2 collisionPoint = ball.Position - Position;
            float hitAngle = collisionPoint.Angle();
            ball.Bounce(new Vector2(Mathf.Cos(hitAngle), Mathf.Sin(hitAngle)));

        }
    }
}
