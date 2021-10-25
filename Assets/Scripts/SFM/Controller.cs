using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FSM
{
    public class Controller : MonoBehaviour
    {
        public State currentState;  // Apuntador al estado actual
        public State remainState;

        public bool ActiveAi { get; set; }

        public void Start()
        {
            ActiveAi = true;    // para activar la IA
        }

        private Animator _animatorController;

        private void Awake()
        {
            _animatorController = GetComponent<Animator>();
            //_healthSystem = GetComponent<HealthSystem>();
        }

        public void Update()    //Se ejecutan las acciones del estado actual.
        {
            if (!ActiveAi) return;  // El parametro
            currentState.UpdateState(this);
        }

        public void Transition(State nextState)
        {
            if (nextState != remainState)
            {
                currentState = nextState;
            }
        }

        public void SetAnimation(string animation, bool value)
        {
            _animatorController.SetBool(animation, value);
        }

        //public int GetCurrentHealth()
        //{
        //    return _healthSystem.GetCurrenthealth();
        //}
    }
}
