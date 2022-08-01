using UnityEngine;
using System.Collections;

public class Command
{
    public virtual void Execute() { }
}

public class CommandFire : Command
{

    public override void Execute()
    {
        Fire();
    }

    void Fire()
    {
        Debug.Log("Fire");
    }

}


public class CommandJump : Command
{

    public override void Execute()
    {
        Jump();
    }

    void Jump()
    {
        Debug.Log("Jump");
    }
}

public class CommandRoll : Command
{

    public override void Execute()
    {
        Roll();
    }

    void Roll()
    {
        Debug.Log("Roll");
    }
}

public class CommandSkill : Command
{

    public override void Execute()
    {
        Skill();
    }

    void Skill()
    {
        Debug.Log("Skill");
    }

}