using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterOnClick2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        GameObject.Find("Player").GetComponent<SaveLoadPosition>().Save();
        SceneManager.LoadScene(8);
    }
}
