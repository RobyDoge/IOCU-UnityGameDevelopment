using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformingPlayer : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _MovementSpeed;
    [SerializeField] private float _JumpSpeed;
    [SerializeField] private float _RotationSpeed;
    private List<Collision> _groundCollisions; 

    void Start()
    {
        _groundCollisions = new List<Collision>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * _MovementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * _MovementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += Vector3.down * _RotationSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles -= Vector3.down * _RotationSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && _groundCollisions.Count > 0)
        {
            _rigidbody.AddForce(new Vector3(0, _JumpSpeed, 0), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.CompareTag("Platform"))
        {
            _groundCollisions.Add(collision);
        }

        if( collision.gameObject.transform.parent?.tag == "Finish")
        {
            SceneManager.LoadScene("VictoryScreen");
        }
        
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            _groundCollisions.Remove(collision);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Chest chest = GameObject.FindAnyObjectByType<Chest>();
            chest.OpenChest();
        }
    }
}


