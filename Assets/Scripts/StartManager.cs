using UnityEngine;

public class StartManager : MonoBehaviour
{
    public static StartManager Instance;
    public string UserName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;

        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}