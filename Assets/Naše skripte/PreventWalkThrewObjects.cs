// using UnityEngine;

// public class PreventWallClip : MonoBehaviour
// {
//     private Vector3 lastSafePosition;

//     void Start()
//     {
//         lastSafePosition = transform.position;
//         Debug.Log("PreventWallClip script has started.");
//     }

//     void Update()
//     {
//         // If we're not colliding with anything, update the last safe position
//         if (!Physics.CheckSphere(transform.position, 0.5f))
//         {
//             lastSafePosition = transform.position;
//             Debug.Log("Updated lastSafePosition to " + lastSafePosition);
//         }
//     }

//     void OnTriggerStay(Collider other)
//     {
//         // If we're colliding with a wall, move back to the last safe position
//         if (other.gameObject.CompareTag("BlockingObject"))
//         {
//             Debug.Log("Collided with " + other.gameObject.name);
//             transform.position = lastSafePosition;
//             Debug.Log("Moved back to " + transform.position);
//         }
//     }
// }