using UnityEngine;

public class ButtonDisable : MonoBehaviour
{
    public GameObject Object;
    public void OnButtonClick()
    {
        Object.SetActive(false);
    }
}
