using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class PermissionRequest : MonoBehaviour
{
    GameObject dialog = null;

    // Start is called before the first frame update
    void Start()
    {
        //AndroidJavaProxy javaProxy = new AndroidJavaProxy("org.tensorflow.lite.examples.posenet.lib.PermissionHelper");
        //AndroidJavaProxy activity = new AndroidJavaProxy("com.unity3d.player.UnityPlayerActivity");

        //javaProxy.Invoke("requestPermission")

        //if (Application.platform == RuntimePlatform.Android)
        //{
        //    if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        //    {
        //        Permission.RequestUserPermission(Permission.Camera);
        //        dialog = new GameObject();
        //    }

        //}
    }

    void OnGUI()
    {
        //if (Application.platform == RuntimePlatform.Android)
        //{
        //    if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        //    {
        //        // The user denied permission to use the microphone.
        //        // Display a message explaining why you need it with Yes/No buttons.
        //        // If the user says yes then present the request again
        //        // Display a dialog here.
        //        NativeDialog dialog = new NativeDialog("TheAppGuruz", "Do you wants to know about TheAppGuruz");
        //        dialog.AddComponent<PermissionsRationaleDialog>();
        //        return;
        //    }
        //    else if (dialog != null)
        //    {
        //        Destroy(dialog);
        //    }

        //}

        //// Now you can do things with the microphone
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
