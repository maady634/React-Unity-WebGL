using UnityEngine;
using Unity.Cinemachine;

[ExecuteAlways]
[DisallowMultipleComponent]
public class ScrollDollyCart : MonoBehaviour
{
    public CinemachinePathBase m_Path;

    public CinemachinePathBase.PositionUnits m_PositionUnits =
        CinemachinePathBase.PositionUnits.Distance;

    [Tooltip("Scroll sensitivity")]
    public float scrollSensitivity = 5f;

    [Tooltip("Current position on path")]
    public float m_Position;

    void Update()
    {
        if (m_Path == null)
            return;

        if (Application.isPlaying)
        {
            float scroll = Input.mouseScrollDelta.y;

            if (Mathf.Abs(scroll) > 0.01f)
            {
                m_Position += scroll * scrollSensitivity;
            }
        }

        SetCartPosition(m_Position);
    }

    void SetCartPosition(float distanceAlongPath)
    {
        m_Position = m_Path.StandardizeUnit(distanceAlongPath, m_PositionUnits);

        var pos = m_Path.EvaluatePositionAtUnit(m_Position, m_PositionUnits);
        var rot = m_Path.EvaluateOrientationAtUnit(m_Position, m_PositionUnits);

        transform.SetPositionAndRotation(pos, rot);
    }
}