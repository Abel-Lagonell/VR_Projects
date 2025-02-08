using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class ButtonDisplay : MonoBehaviour
{
    public GameObject textDisplay;

    public void OnClick() {
        textDisplay.SetActive(!textDisplay.activeSelf);
    }
}
