using Drawing;
using System.Collections.Generic;
using UnityEngine;

public class CustomBouncingBall : MonoBehaviour , IListener {

    [SerializeField] private Transform Ball; // Reference to the ball Ball

    float gravity = 9.8f; // Gravity force
    float bounceForce = 0.5f; // Bounce force multiplier
    float initialVerticalVelocity = 10f; // Initial upward velocity
    float initialHorizontalVelocity = 1f; // Initial horizontal velocity
    
    private Vector3 velocity;

    // for debug:
    List<(Vector3, Vector3)> collisionPoints;

    void Start() {

        // Add a ColliderBridge component to the ball if it doesn't have one:
        if (Ball.GetComponent<ColliderBridge>() == null) {
            Ball.gameObject.AddComponent<ColliderBridge>().Listener = this;
        }

        // Apply initial velocities
        velocity = new Vector3(initialHorizontalVelocity, initialVerticalVelocity, 0);

        collisionPoints = new ();

    }

    void Update() {
        // Apply gravity
        velocity.y -= gravity * Time.deltaTime;

        // Move the ball
        Ball.Translate(velocity * Time.deltaTime);

        // Debug-draw all contact points and normals
        foreach (var collisionPoint in collisionPoints) {
            Debug.DrawRay(collisionPoint.Item1, collisionPoint.Item2, Color.white);

            Draw.ingame.Arrow(collisionPoint.Item1, collisionPoint.Item1 + collisionPoint.Item2, Color.white);

        }

        // Draw the velocity vector:
        Debug.DrawRay(Ball.position, velocity, Color.red);
        Draw.ingame.Arrow(Ball.position, Ball.position + velocity, Color.red);

        // Draw the gravity vector:
        Debug.DrawRay(Ball.position, Vector3.down * gravity, Color.green);
        Draw.ingame.Arrow(Ball.position, Ball.position + Vector3.down * gravity, Color.green);

    }

    void Bounce(Vector3 collisionNormal) {
        // Reflect the velocity off the plane normal
        velocity = Vector3.Reflect(velocity, collisionNormal) * bounceForce;

        // Optionally, reduce horizontal velocity on bounce to simulate friction
        Vector3 horizontalVelocity = Vector3.ProjectOnPlane(velocity, Vector3.up);
        velocity = horizontalVelocity * 0.9f + Vector3.up * velocity.y;
    }

    void IListener.OnCollisionEnter(Collision collision) {
        Debug.Log(this + "reacting to Collision via IListener");

        // Debug add current contact point and normal
        collisionPoints.Add((collision.contacts[0].point, collision.contacts[0].normal));

        // Bounce on the first object:
        Bounce(collision.contacts[0].normal);
    }
}
