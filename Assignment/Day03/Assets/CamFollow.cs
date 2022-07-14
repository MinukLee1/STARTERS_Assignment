using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public enum State
    {
        Idle,Ready,Tracking
    }

    private State state
    {
        set
        {
            switch (value)
            {
                case State.Idle:
                    targetZoomSize = roundReadyZoomSize;
                    break;
                case State.Ready:
                    targetZoomSize = readyShotZoomSize;
                    break;
                case State.Tracking:
                    targetZoomSize = trackingZoomSize;
                    break;
            }
        }
    }

    private Transform target;

    public float smoothTime = 0.2f;

    private Vector3 lastmovingVelocity;
    private Vector3 targetPosition;

    private Camera cam;
    private float targetZoomSize = 5f;

    private const float roundReadyZoomSize = 14.5f;
    private float readyShotZoomSize = 5f;
    private float trackingZoomSize = 10f;

    private float lastZoomSpeed;

    private void Awake()
    {
        cam = GetComponentInChildren<Camera>();
        state = State.Idle;
    }

    //카메라가 타겟에 맞추어서 움직임
    private void Move()
    {
        targetPosition = target.transform.position;

        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, targetPosition,
            ref lastmovingVelocity, smoothTime);

        transform.position = targetPosition;
    }
    private void Zoom()
    {
        float smoothZoomSize = Mathf.SmoothDamp(cam.orthographicSize, targetZoomSize, ref lastZoomSpeed,
            smoothTime);

        cam.orthographicSize = smoothZoomSize;
    }


    //fixedUpdate는 시간간격이 일정하다 -> 정확한 계산시 주로 사용 
    private void FixedUpdate()
    {
        if(target != null)
        {
            Move();
            Zoom();
        }
        
    }

    public void Reset()
    {
        state = State.Idle;
    }

    public void SetTarget(Transform newTarget, State newState)
    {
        target = newTarget;
        state = newState;
    }


}
