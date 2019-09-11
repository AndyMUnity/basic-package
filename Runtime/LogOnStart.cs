using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TestPackage
{
    public class LogOnStart : UIBehaviour
    {
        void Start()
        {
            Debug.Log( "Im a monoBehaviour" );
        }
    }
}
