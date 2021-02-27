using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum State { MainMenu, InGame, Win, Lose};


    public State currentState;


    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }


    #region MonoBehaviour function
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    public void WinLevel()
    {

    }

    public void LoseLevel()
    {

    }

    public void LoadLevel()
    {

    }

    public void StartLevel()
    {

    }

    public void ChangeState(State state)
    {
        currentState = state;
        UIManager.Instance.UpdateState(state);
    }
}
