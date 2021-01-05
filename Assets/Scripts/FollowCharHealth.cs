using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharHealth : MonoBehaviour
{
    public Transform character;
    public Transform bar;

    void Update()
    {
        this.transform.SetParent(character);
        this.transform.eulerAngles = new Vector3(0, 180, 0);
    }
}
