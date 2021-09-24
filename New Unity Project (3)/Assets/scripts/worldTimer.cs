using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldTimer : MonoBehaviour
{
    
    public static float _worldTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        _worldTimer = TimeMaster.CheckDate();
        Debug.Log("времяяя  " + _worldTimer);
    }
    
    // Update is called once per frame
    void Update()
    {
     }   
}
