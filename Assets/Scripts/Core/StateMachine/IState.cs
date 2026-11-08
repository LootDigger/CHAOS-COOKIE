using System;

namespace Patterns.AbstractStateMachine
{
    public interface IState
    {
        public StateMachine StateMachine { get; set; }

        void EnterState();
        void ExitState();
        void UpdateState();
    }
}