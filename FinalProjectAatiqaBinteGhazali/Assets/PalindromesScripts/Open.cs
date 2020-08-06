using UnityEngine;
  using System.Collections;
  
  public class Open: MonoBehaviour
  {
      public void OpenURL()
      {
          Application.OpenURL("http://www.niazilab.com");
          Debug.Log("is this working?");
      }
  
  }