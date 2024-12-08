
using UnityEngine;

public class PreviousTime : MonoBehaviour
{
    [SerializeField]
    private PreviousTimeLoader _previousTimeLoader;

    private void Start()
    {
        _previousTimeLoader.Load();
    }
}
