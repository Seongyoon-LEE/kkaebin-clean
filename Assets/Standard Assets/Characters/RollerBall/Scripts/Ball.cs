using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Ball
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private float m_MovePower = 1; // The force added to the ball to move it.
     
        [SerializeField] private float m_MaxAngularVelocity = 25; // The maximum velocity the ball can rotate at.
        
        public float jumpPower = 7;

       
        private Rigidbody m_Rigidbody;
       
        bool isJump;

        

        void Awake()
        {
            isJump = false;
        }

        void Update()
        {
            
            if (Input.GetButtonDown("Jump") && !isJump )
            {
                isJump = true;
                m_Rigidbody.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
            }
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Floor")
                isJump = false;
        }

        void OnCollisionStay(Collision collision)
        {
            if (collision.gameObject.tag == "Jump")
            {
                m_Rigidbody.AddForce(Vector3.up * 500);
            }

            if (collision.gameObject.tag == "little Jump")
            {
                m_Rigidbody.AddForce(Vector3.up * 100);
                isJump = false;
                
            }


        }

        private void OnTriggerStay(Collider other)
        {

            if (other.tag == "Wind")
            {
                m_Rigidbody.AddForce(Vector3.back * 1);
            }
            if (other.tag == "Space")
            {
                m_Rigidbody.AddForce(Vector3.up * 5);

            }
            if(other.tag == "Galaxy")
            {
                m_Rigidbody.AddForce(Vector3.up * 10);

            }
        }

        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
            // Set the maximum angular velocity.
            GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }


        public void Move(Vector3 moveDirection, bool isJump)
        {
            
           
            
            {
                // Otherwise add force in the move direction.
                m_Rigidbody.AddForce(moveDirection*m_MovePower);
            }

          
            
        }
    }
}
