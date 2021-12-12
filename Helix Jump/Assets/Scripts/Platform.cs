using System;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scipts
{
    public class Platform : MonoBehaviour
    {

        public GameObject objScores;
        public GameObject objRecord;
        private Text scores;
        private Text record;
        private BtnFX btn;
        public ParticleSystem boom;
        
      
        private void Start()
        {
            objScores = GameObject.Find("Score"); // не забудь это говно переписать
            scores = objScores.GetComponent<Text>();
            objRecord = GameObject.Find("ScoresBest");// и это
            record = objRecord.GetComponent<Text>();
        }

        private void OnTriggerEnter(Collider other)
        {
            
            if (other.TryGetComponent(out Player player))
            {
                player.CurrentPlatform = this;
                Game.scores++;
                scores.text = Game.scores.ToString();
                record.text = "Record: "+ Game.Record().ToString();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                if (other.GetComponent<Player>().CurrentPlatform)
                {
                    boom.Play();
                    Invoke("Delay",0.2f);
                    
                }
                
                player.audioBreakPlatform.Play();
                
            }
        }
        private void Delay()
        {
            Destroy(gameObject);
        }
        
        
    }
}