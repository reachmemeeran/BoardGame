using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    float m_h;
    public float H { get { return m_h; } }

    float m_v;
    public float V { get { return m_v; } }

    bool inputEnabled = false;
    public bool InputEnabled { get { return inputEnabled; } set { inputEnabled = value; } }

    public void GetKeyInput()
    {
        if (inputEnabled)
        {
            m_h = Input.GetAxisRaw("Horizontal");
            m_v = Input.GetAxisRaw("Vertical");
        }
    }

    //public bool GetInputEnabled()
    //{
    //    return inputEnabled;
    //}
    //public void SetInputEnabled(bool myValue)
    //{
    //    inputEnabled = myValue;
    //}

}
