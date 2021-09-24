using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideUi : MonoBehaviour
{
    public GameObject Ui;
 public void Exit()
  {
        Ui.SetActive(false);
        showUi.uiIsActive = false;
  }
}
