using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField]Calendar calendar;
    public int GameDay = 1;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void ToNextDay()
    {
        GameDay += 1;
        calendar.UpdateVisuals();
    }
}
