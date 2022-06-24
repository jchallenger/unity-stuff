using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [Range(1f, 10f)]
    public float moveForce = 1f;
    public Transform followTarget;
    Vector3 idealDistance;
    void OnDrawGizmos(){
        drawGizmos(false);
    }
    void OnDrawGizmosSelected(){
        drawGizmos (true);
    }

    void drawGizmos(bool selected){
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(gameObject.transform.position, followTarget.position);
    }

    // Start is called before the first frame update
    void Start()
    {
        idealDistance = gameObject.transform.position - followTarget.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = gameObject.transform.position - followTarget.position;
        gameObject.transform.position += (idealDistance - dist) * Time.deltaTime * moveForce;
    }
}
