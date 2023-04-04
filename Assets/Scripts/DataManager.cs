using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    private void Awake()
    {
        if (Instance != null )
        {
            Destroy(gameObject);
            
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
