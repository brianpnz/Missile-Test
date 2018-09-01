using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCubeButton : MonoBehaviour {


    public void RotateCube()
    {
        transform.Rotate(0f, 45f, 0f);
    }
}
