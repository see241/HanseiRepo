using System.Diagnostics;
using UnityEngine;

using Debug = UnityEngine.Debug;
public class Cube_1 : MonoBehaviour
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

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsPressed(eBtn.BtnX))
            Fire();
        else if (IsPressed(eBtn.BtnY))
            Jump();
        else if (IsPressed(eBtn.BtnA))
            Roll();
        else if (IsPressed(eBtn.BtnB))
            Skill();
    }

    void Fire()
    {
        Debug.Log("Fire");
    }
    void Jump()
    {
        Debug.Log("Jump");
    }
    void Roll()
    {
        Debug.Log("Roll");
    }
    void Skill()
    {
        Debug.Log("Skill");
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