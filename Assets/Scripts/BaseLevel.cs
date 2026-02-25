using UnityEngine;
using UnityEngine.Events;

public class BaseLevel : MonoBehaviour
{
    public UnityEvent OnLevelWin;
    public UnityEvent OnLevelLose;

    public void Win(){
        Debug.Log("Рівень пройдено");
        OnLevelWin?.Invoke();
    }

    public void Lose(){
        Debug.Log("Помилка");
        OnLevelLose?.Invoke();
    }

    
}

