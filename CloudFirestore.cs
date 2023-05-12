using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Firestore;
using UnityEngine.UI;

public class CloudFirestore : MonoBehaviour
{
    FirebaseFirestore db;
    Dictionary<string, object> user;
    [SerializeField]InputField Username;
    [SerializeField]InputField email;
    [SerializeField]InputField events;
    [SerializeField]InputField dateofbirth;
    
    void Start()
    {
        db = FirebaseFirestore.DefaultInstance;
        
    }
    public void savedata(){
         user = new Dictionary<string, object>
         {
             {"UserName", Username.text},
             {"Email", email.text},
             {"Events", events.text},
             {"Date of Birth", dateofbirth.text},
         };

         db.Collection("Users").Document(Username.text).SetAsync(user).ContinueWith(task =>
         {
             if(task.IsCompleted){
                 Debug.Log("Successfully added text to database");
             }
             else{
                 Debug.Log("Not Successfull");
             }
         });
    }
    
}
