using UnityEngine;

public class BreakJoint : MonoBehaviour
{
    private HingeJoint2D _hingeJoint;

    private void Update()
    {
        _hingeJoint = GetComponent<HingeJoint2D>();
        if (Input.GetMouseButtonDown(0))
            Destroy(_hingeJoint);
    }

}
