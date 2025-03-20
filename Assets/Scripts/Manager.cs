using UnityEngine;

public class Manager : MonoBehaviour
{
    #region Singleton
    public static Manager Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public enum Tags
    {
        Tag1,
        Tag2,
        Tag3
    }
}