using UnityEngine;

public class ClickAction : MonoBehaviour
{
    public bool isWinner = false;

    void OnMouseDown()
    {
        BaseLevel level = GetComponentInParent<BaseLevel>();
        if (isWinner) level.Win();
        else level.Lose();
    }
}
