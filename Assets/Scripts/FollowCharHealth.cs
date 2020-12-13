using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharHealth : MonoBehaviour
{
    public Transform character;
    Quaternion rot;

    private void Start()
    {
        rot = this.gameObject.transform.rotation;
    }

    void Update()
    {
        this.transform.SetParent(character);
    }
}
