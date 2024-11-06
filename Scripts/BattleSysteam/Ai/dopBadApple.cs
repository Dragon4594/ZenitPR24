using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dopBadApple : MonoBehaviour
{
    #region Singleton
    public static dopBadApple instance;
    private void Awake(){
        instance = this;
    }
    #endregion
    public GameObject playerDopBedApple;
}
