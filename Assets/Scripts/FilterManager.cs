using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class FaceFilterManager : MonoBehaviour
{
    private ARFaceManager faceManager;
    public GameObject[] filters; 

    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
        faceManager.facePrefab = null; 
    }

    public void ChangeFaceFilter(int index)
    {
        
        if (index >= 0 && index < filters.Length)
        {
            
            faceManager.facePrefab = filters[index];
            ResetFaceTracking();
        }
    }

    private void ResetFaceTracking()
    {
        
        faceManager.enabled = false;  
        faceManager.enabled = true;   
    }

}
