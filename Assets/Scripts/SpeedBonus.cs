using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    private float time = 0f;
    private float maxSpeed;
    private float upSpeed;
    private moveChairsTrue mct;
    public bool run = false;

    void Start()
    {
        mct = GameObject.FindWithTag("Player").GetComponent<moveChairsTrue>();
    }

    private void FixedUpdate()
    {
        if (run == true)
        {
            time += Time.deltaTime;
            if (time < 2f)
            {
                mct.SpeedMovementUp = 45f; 
                mct.SpeedMovementMax = 300f;
            }
            else
            {
                mct.SpeedMovementMax = maxSpeed;
                mct.SpeedMovementUp = upSpeed;
                mct.SpeedMovement = maxSpeed;
                run = false;
                time = 0f;
            }
        }
        else
        {
            maxSpeed = mct.SpeedMovementMax;
            upSpeed = mct.SpeedMovementUp;
        }
    }
}
