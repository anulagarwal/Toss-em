using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanonUIManager : MonoBehaviour
{
    [SerializeField] private Image cooldownImg;
    [SerializeField] private CanonManager cm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cm.currentHumanCount < cm.maxHuman)
        {

        }
    }
}
