using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behavior/StayInRadius")]
public class StayInRadiusBehavior : SchoolBehavior
{
    
    public Vector2 center;
    public float radius = 15f;

    public override Vector2 CalculateMove(SchoolingAgent agent, List<Transform> context, FishSchool school)
    {
        Vector2 centerOffset = center - (Vector2)agent.transform.position;
        // ---- If t is zero, object is at the center of the circle ----
        float t = centerOffset.magnitude / radius;
        if (t < 0.9f)
        {
            return Vector2.zero;
        }

        // ---- squaring "t" to give it a quadratic curve ----
        return centerOffset * t * t;
    }
}
