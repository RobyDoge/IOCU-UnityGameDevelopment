using UnityEngine;
using UnityEngine.SceneManagement;

public class NavMeshPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _WinCondition;
    private PreviousTimeSaver _previousTimeSaver;

    private WinSaver _winSaver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _previousTimeSaver = FindAnyObjectByType<PreviousTimeSaver>();
        _winSaver = FindAnyObjectByType<WinSaver>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, _WinCondition.transform.position);

        if (distance < 1)
        {
            _previousTimeSaver.Save();
            _winSaver.Save();
            SceneManager.LoadScene("VictoryScreen");
        }

    }
}
