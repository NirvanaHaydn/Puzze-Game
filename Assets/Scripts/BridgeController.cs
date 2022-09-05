using UnityEngine;

public class BridgeController : MonoBehaviour
{
    [SerializeField]private HingeJoint[] invertBridges;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            foreach (HingeJoint bridge in invertBridges)
            {
                JointSpring currentSpring = bridge.spring;
                if(currentSpring.spring == 0)
                {
                    currentSpring.spring = 1000000;
                }
                else
                {
                    currentSpring.spring = 0;
                }
                bridge.spring = currentSpring;
            }
        }
    }
}
