using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public Player_movement movement;

    void OnCollisionEnter(Collision collision_Info)
    {
        if (collision_Info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("hit");
        }

    }
}
