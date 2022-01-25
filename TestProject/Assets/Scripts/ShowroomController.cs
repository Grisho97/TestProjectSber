using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowroomController : MonoBehaviour
{
    [SerializeField] private ItemsHolder itemsHolder;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(itemsHolder.GetPrefab(), Vector3.zero, Quaternion.identity);
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
