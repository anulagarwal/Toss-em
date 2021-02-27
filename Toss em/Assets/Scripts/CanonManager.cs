using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonManager : MonoBehaviour
{
    [SerializeField] public float cooldown;
    [SerializeField] public int maxHuman;
    [SerializeField] public int currentHumanCount;


    public GameObject human;
    private float startTime;
    #region MonoBehaviour functions
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startTime + cooldown < Time.time)
        {
            AddHumanCount();
        }
    }

    #endregion

    public void AddHumanCount()
    {
        if (currentHumanCount < maxHuman)
        {
            currentHumanCount++;
        }
    }

    public void Shoot()
    {
        //Add Force to human in the direction pointing

        if (currentHumanCount > 0)
        {
            currentHumanCount--;
        }
    }

    
}
