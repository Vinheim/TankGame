using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanks
{
    public class ThirdPersonMovement : MonoBehaviour
    {
        // Create references to tank control and camera.
        public CharacterController controller;
        public GameObject tank;
        public Rigidbody rb;
        public Transform camera;
        // Define speed for tank and declare variables to use in Euler/Quaternion/Angular conversion and rotation.
        public float speed = 10f;
        public float turnSpeed = 20f;
        // Smooth rotation
        public float smoothTurnTime = 5f;
        public float smoothTurnVelocity;

        // Awake
        private void Awake()
        {
                
        }

        private void FixedUpdate()
        {
            // ......
        }


        // Update is called once per frame
        void Update()
        {
            // Active simple movement reading input on the WASD/Arrow keys.
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            // Calculate new direction and store in Vector3 to change direction following normalization on key press.
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            // If direction magnitude >= 0.1f, then move tank asset on terrain.
            /*
            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurnVelocity, smoothTurnTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
                Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(moveDirection.normalized * speed * Time.deltaTime);
            }
            */

            // Individually read key presses for WASD/Arrow keys separately
            // More specific movement instructions on WASD only.

            if (Input.GetKey(KeyCode.W))
                transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.S))
                transform.Translate(-Vector3.forward * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.A))
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.D))
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}
