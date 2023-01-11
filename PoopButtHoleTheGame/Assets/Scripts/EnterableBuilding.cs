using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterableBuilding : MonoBehaviour
{
    [SerializeField] private string _buildingSceneName;

    public void EnterToBuilding() 
    {
        SceneManager.LoadScene(_buildingSceneName);
    }
}
