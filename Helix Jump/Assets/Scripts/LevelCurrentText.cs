using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scipts
{
    public class LevelCurrentText : MonoBehaviour
    {
        public Text Text;
        public Game Game;
        // Start is called before the first frame update
        void Start()
        {
            Text.text = (Game.LevelIndex + 1).ToString();
        }      
    }
}
