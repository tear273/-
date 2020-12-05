using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Controller : MonoBehaviour
{
    public bool startPlay;
    public bool Player;

    //자동차 모터, 각도값
    float motor;
    float steering;

    //WheelCollider 받아오기
    public WheelCollider FrontLeft;
    public WheelCollider FrontRight;
    public WheelCollider RearLeft;
    public WheelCollider RearRight;

    //VisualWheel을 위한것
    WheelFrictionCurve fFrictionRWL;
    WheelFrictionCurve sFrictionRWL;
    WheelFrictionCurve fFrictionRWR;
    WheelFrictionCurve sFrictionRWR;

    //최대 모터회전수, 회전각도 설정
    public float maxMotorTorque;
    public float maxSteeringAngle;

    //컨트롤러 구분을 위한 변수
    public float Player1_horizontal;
    public float Player1_vertical;

    public float Player2_horizontal;
    public float Player2_vertical;

    private void Awake()
    {
        startPlay = false;
    }

    private void Start()
    {

        fFrictionRWL = RearLeft.forwardFriction;
        sFrictionRWL = RearLeft.sidewaysFriction;
        fFrictionRWR = RearRight.forwardFriction;
        sFrictionRWR = RearRight.sidewaysFriction;
    }
    private void Update()
    {
        if (startPlay)
        {
            VisualWheel(FrontLeft);
            VisualWheel(FrontRight);
            VisualWheel(RearLeft);
            VisualWheel(RearRight);

            if (Player)
            {
                ArrowKeysVer();
                ArrowKeyHor();
            }
            else
            {
                WASDVer();
                WASDHor();
            }
        }
    }

    void VisualWheel(WheelCollider collider)
    {
        Transform visualWheel = collider.transform.GetChild(0);

        Vector3 position;
        Quaternion rotation;

        collider.GetWorldPose(out position, out rotation);

        //rotation.eulerAngles += new Vector3(0, 0, 90);

        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }

    void ArrowKeysVer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Player1_vertical <= 1)
            {
                Player1_vertical += Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Player1_vertical >= -1)
            {
                Player1_vertical -= Time.deltaTime;
            }
        }
        else
        {
            Player1_vertical = 0;
        }

        motor = maxMotorTorque * Player1_vertical;

        FrontLeft.motorTorque = motor;
        FrontRight.motorTorque = motor;
    }

    void ArrowKeyHor()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Player1_horizontal <= 1)
            {
                Player1_horizontal += Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Player1_horizontal >= -1)
            {
                Player1_horizontal -= Time.deltaTime;
            }
        }
        else
        {
            Player1_horizontal = 0;
        }

        steering = maxSteeringAngle * Player1_horizontal;

        FrontLeft.steerAngle = steering;
        FrontRight.steerAngle = steering;

    }

    void WASDVer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Player2_vertical <= 1)
            {
                Player2_vertical += Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (Player2_vertical >= -1)
            {
                Player2_vertical -= Time.deltaTime;
            }
        }
        else
        {
            Player2_vertical = 0;
        }

        motor = maxMotorTorque * Player2_vertical;

        FrontLeft.motorTorque = motor;
        FrontRight.motorTorque = motor;
    }

    void WASDHor()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (Player2_horizontal <= 1)
            {
                Player2_horizontal += Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (Player2_horizontal >= -1)
            {
                Player2_horizontal -= Time.deltaTime;
            }
        }
        else
        {
            Player2_horizontal = 0;
        }

        steering = maxSteeringAngle * Player2_horizontal;

        FrontLeft.steerAngle = steering;
        FrontRight.steerAngle = steering;

    }
}
