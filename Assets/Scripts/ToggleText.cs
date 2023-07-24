using UnityEngine;

public class ToggleText : MonoBehaviour
{
    public GameObject Object;

    public void OnToggleChanged(bool state)
    {
        Object.SetActive(state);
    }
}
