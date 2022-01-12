using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour
{
    public Transform target;

    public float smoothTime;
    public float maxSpeed;
    public float dampTime;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    private Vector3 VelocityF = Vector3.zero;
    private void Start(){
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void FixedUpdate(){
        FollowTarget();
    }

    void FollowTarget(){
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);


        targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.x);
        targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref VelocityF, smoothTime, maxSpeed, dampTime);
    }
}
