using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    public Transform target;
    private void Update()
    {
        // Lance will follow Circle ; ROTATE lance
        Vector3 targ = target.transform.position;
             targ.z = 0f;
 
             Vector3 objectPos = transform.position;
             targ.x = targ.x - objectPos.x;
             targ.y = targ.y - objectPos.y;
 
             float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
             transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
