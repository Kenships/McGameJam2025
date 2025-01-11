using UnityEngine;
using TMPro;

public class TestButton : MonoBehaviour
{
  public TextMeshProUGUI BtnText;
  public GameObject ButtonTemp;
  GameObject newBtn;

  public void FancyButtonPressed() {
    newBtn = Instantiate(ButtonTemp, transform);
  }
 // hello there   
}
