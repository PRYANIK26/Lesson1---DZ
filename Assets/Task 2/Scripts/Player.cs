using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Gun _currentGun;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentGun.Shot();
        }
    }

    public void SetGun(Gun gun)
    {
        _currentGun = gun;
    }
}
