using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    // Inspecterで値を変更する
    public float spring = 40000;
    public float openAngle = 60; // 開く角度
    public float closeAngle = 0; // 閉じる角度
    public KeyCode keyCode = KeyCode.A;

    // Hinge Joint
    private HingeJoint hinjiJoint;
    // JointSpring
    private JointSpring jointSpring;

    // Start is called before the first frame update
    void Start()
    {
        hinjiJoint = GetComponent<HingeJoint>();
        jointSpring = hinjiJoint.spring;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            jointSpring.spring = spring;
            jointSpring.targetPosition = openAngle;
            hinjiJoint.spring = jointSpring;
        }
        if (Input.GetKeyUp(keyCode))
        {
            jointSpring.spring = spring;
            jointSpring.targetPosition = closeAngle;
            hinjiJoint.spring = jointSpring;
        }

    }
}