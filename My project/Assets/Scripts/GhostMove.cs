// Comment
using UnityEngine;
using System.Collections;

public class GhostMove : MonoBehaviour {

    public Transform[] waypoints;
    int cur = 0;

    public float speed = 0.3f;

    // Use this for initialization
    void Start() {

    }

    void FixedUpdate () {
    // Waypoint not reached yet? then move closer
   if (Vector2.Distance(transform.position, waypoints[cur].position) < 0.1f)
    { if (cur == waypoints.Length - 1)
     { cur = 0; } else { cur++; } }
      // Waypoint reached, select next one 
      else { Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, speed);
      GetComponent<Rigidbody2D>().MovePosition(p);
      }
    // Animation
    Vector2 dir = waypoints[cur].position - transform.position;
    GetComponent<Animator>().SetFloat("DirX", dir.x);
    GetComponent<Animator>().SetFloat("DirY", dir.y);
}

    void OnTriggerEnter2D(Collider2D co) {
    if (co.name == "PacMan")
        Destroy(co.gameObject);
    }
    
}
