using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
public void Pause()
 {
    pauseMenu.SetActivate(true);
 }
 public void Home()
 {
    SceneManager.LoadScene("Main Menu");
 }
 public void Resume()
 {
    pauseMenu.SetActivate(false);
 }
 public void Restart()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 }

}
