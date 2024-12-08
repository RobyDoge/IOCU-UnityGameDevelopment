using UnityEngine;

public class FirstScript : MonoBehaviour
{
    private float _xScaleFactor;
    [SerializeField] private float _YScaleFactor2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _xScaleFactor = 2.0f;
        Debug.Log($"xScaleFactor = {_xScaleFactor}\n yScaleFactor = {_YScaleFactor2}");
        transform.localScale = new Vector3(_xScaleFactor, _YScaleFactor2, 1.0f);
        transform.position = new Vector3(_xScaleFactor, _YScaleFactor2, 1.0f);
        transform.eulerAngles = new Vector3(_xScaleFactor, _YScaleFactor2, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Vector3 mousePosition = Input.mousePosition;

      
        Debug.Log($"Mouse Clicked at: {mousePosition}");
        transform.position = mousePosition;
    }
}
