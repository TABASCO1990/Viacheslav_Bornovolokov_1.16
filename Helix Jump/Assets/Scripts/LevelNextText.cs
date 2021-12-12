using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scipts
{
    public class LevelNextText : MonoBehaviour
    {
        public Text Text;
        public Game Game;
        // Start is called before the first frame update
        void Start()
        {
            Text.text = "" + (Game.LevelIndex + 2).ToString();
        }
    }
}
