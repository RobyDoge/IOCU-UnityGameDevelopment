
using UnityEngine;

public class WinCounter : MonoBehaviour
{
    [SerializeField]
    private WinLoader _WindLoader;

    private void Start()
    {
        _WindLoader.Load();
    }
}
