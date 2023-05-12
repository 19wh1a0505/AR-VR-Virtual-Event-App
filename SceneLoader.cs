using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LobbyAuditorium(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LobbyHuddle(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
     public void LobbyNetwork(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
     }
      public void LobbyResources(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
     }
    public void LobbyWallframe(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void LobbyConnectLearn(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void LobbyCineHall(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void LobbyMeet(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
     public void LobbyRegistration(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }
    public void LobbySurvey(){
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }
        public void Auditorium(){
        SceneManager.LoadScene(0);
    }
      public void HuddelRoom(){
        SceneManager.LoadScene(0);
    }
    public void Networking(){
        SceneManager.LoadScene(0);
    }
    
    public void Resources(){
        SceneManager.LoadScene(0);
    }
    
    public void WallFrame(){
        SceneManager.LoadScene(0);
    }
    public void ConnectLearn(){
        SceneManager.LoadScene(0);
    }
    public void CineHall(){
        SceneManager.LoadScene(0);
    }
     public void MeetRoom(){
        SceneManager.LoadScene(0);
    }
    public void Registration(){
        SceneManager.LoadScene(0);
    }
    public void Survey(){
        SceneManager.LoadScene(0);
    }
    public void Video(){
        SceneManager.LoadScene(10);
    }
}