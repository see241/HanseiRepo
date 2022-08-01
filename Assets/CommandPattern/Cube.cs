
using UnityEngine;
using System.Collections;
 
public class Cube : MonoBehaviour
{
    public enum eBtn
    {
        BtnX,
        BtnY,
        BtnA,
        BtnB,
        None
    }

    eBtn pressedBtn = eBtn.None;

    Command bX, bY, bA, bB;

    // Use this for initialization
    void Start()
    {
        SetCommand();
    }

    void SetCommand()
    {
        bX = new CommandFire();
        bY = new CommandJump();
        bA = new CommandRoll();
        bB = new CommandSkill();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPressed(eBtn.BtnX)) bX.Execute();
        else if (IsPressed(eBtn.BtnY)) bY.Execute();
        else if (IsPressed(eBtn.BtnA)) bA.Execute();
        else if (IsPressed(eBtn.BtnB)) bB.Execute();

    }

    bool IsPressed(eBtn btn)
    {
        pressedBtn = eBtn.None;

        if (Input.GetKey("x"))
            pressedBtn = eBtn.BtnX;
        else if (Input.GetKey("y"))
            pressedBtn = eBtn.BtnY;
        else if (Input.GetKey("a"))
            pressedBtn = eBtn.BtnA;
        else if (Input.GetKey("b"))
            pressedBtn = eBtn.BtnB;

        return (btn == pressedBtn);
    }

}