using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameButton : MonoBehaviour, IActivatable
{     
        [SerializeField]
        private string nameText;

        public string NameText { get { return nameText; } }

        public void DoActivate()
        {
            // need to add using UnityEngine.UI;
            
        }    
}