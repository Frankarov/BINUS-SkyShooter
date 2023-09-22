using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MyCode
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;
        public GameObject activePlayer;
        public GameObject playerPrefab;
        public bool isPlaying;

        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public static GameManager GetInstance()
        {
            return instance;
        }

        private void Start()
        {
            spawnPlayer();
        }

        void spawnPlayer()
        {
            activePlayer = Instantiate(playerPrefab);
        }

        public Vector3 getPlayerPosition()
        {
            if(activePlayer != null)
            {
                return activePlayer.transform.position;
            }
            return Vector3.zero;
        }

        public void startGame()
        {
            isPlaying = true;
            spawnPlayer();
        }

        public void resumeGame()
        {
            isPlaying = true;
            Time.timeScale = 1;
        }

        public void pauseGame()
        {
            isPlaying = false;
            Time.timeScale = 0;
        }

        public UnityAction OnGameOverAction;
        internal void gameOver()
        {
            isPlaying = false;
            OnGameOverAction?.Invoke();
        }

        public myScriptableInteger life;
        public EnemySpawner spawner;
        internal void retry()
        {
            life.reset();
            spawner.clearEnemies(); 
            ObjectPool.GetInstance().deactivateAllObject(); 
        }

    }
}

