using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    [SerializeField] private float _ScaleFactor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
            transform.localScale += new Vector3(_ScaleFactor, _ScaleFactor, _ScaleFactor);
        if (Input.GetKey(KeyCode.O))
            transform.localScale -= new Vector3(_ScaleFactor, _ScaleFactor, _ScaleFactor);
    }
}
