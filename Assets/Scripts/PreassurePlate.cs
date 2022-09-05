using UnityEngine;

public class PreassurePlate : MonoBehaviour
{
    [SerializeField] private HingeJoint[] bridgesToActive, bridgesToDeactivate;
    private GameObject otherObject;
    private bool hasStartedCollision;

    private void FixedUpdate()
    {
        DetectExistence();
    }

    private void DetectExistence()
    {
        if (hasStartedCollision)
        {
            if (otherObject != null)
            {
                Active();
            }
            else
            {
                hasStartedCollision = false;
                Innactive();
            }
        }
    }

    private void Active()
    {
        foreach (HingeJoint bridge in bridgesToActive)
        {
            JointSpring currentSpring = bridge.spring;
            currentSpring.spring = 1000000;
            bridge.spring = currentSpring;
        }

        foreach (HingeJoint bridge in bridgesToDeactivate)
        {
            JointSpring currentSpring = bridge.spring;
            currentSpring.spring = 0;
            bridge.spring = currentSpring;
        }
    }

    private void Innactive()
    {
        foreach (HingeJoint bridge in bridgesToActive)
        {
            JointSpring currentSpring = bridge.spring;
            currentSpring.spring = 0;
            bridge.spring = currentSpring;
        }

        foreach (HingeJoint bridge in bridgesToDeactivate)
        {
            JointSpring currentSpring = bridge.spring;
            currentSpring.spring = 1000000;
            bridge.spring = currentSpring;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Box"))
        {
            otherObject = other.gameObject;
            hasStartedCollision = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("Box"))
        {
            otherObject = null;
        }      
    }
}
