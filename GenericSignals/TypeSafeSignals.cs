using System;
using MattMert.Common;

namespace MattMert.GenericSignals
{
    public class Signals : ATypeSafeMain<SignalHub>
    {
        public static void PauseSignals(object id)
        {
            hub.PauseSignals(id);
        }

        public static void ResumeSignals(object id)
        {
            hub.ResumeSignals(id);
        }

        public static void PauseAllSignals()
        {
            hub.PauseAllSignals();
        }

        public static void ResumeAllSignals()
        {
            hub.ResumeAllSignals();
        }
    }

    public class SignalHub : ATypeSafeHub
    {
        public void PauseSignals(object id)
        {
            foreach (var typeSafe in objs.Values)
            {
                if (typeSafe is not ABaseSignal signal)
                    continue;

                if (signal.SignalId == id)
                    signal.PauseSignal();
            }
        }

        public void ResumeSignals(object id)
        {
            foreach (var typeSafe in objs.Values)
            {
                if (typeSafe is not ABaseSignal signal)
                    continue;

                if (signal.SignalId == id)
                    signal.ResumeSignal();
            }
        }

        public void PauseAllSignals()
        {
            foreach (var typeSafe in objs.Values)
            {
                if (typeSafe is not ABaseSignal signal)
                    continue;

                signal.PauseSignal();
            }
        }

        public void ResumeAllSignals()
        {
            foreach (var typeSafe in objs.Values)
            {
                if (typeSafe is not ABaseSignal signal)
                    continue;

                signal.ResumeSignal();
            }
        }
    }

    public abstract class ABaseSignal : ATypeSafe
    {
        protected abstract ISignal signal { get; }
        public bool IsPaused => signal.IsPaused;
        public object SignalId => signal.SignalId;

        public void SetId(object id)
        {
            signal.SetId(id);
        }

        public void PauseSignal()
        {
            signal.PauseSignal();
        }

        public void ResumeSignal()
        {
            signal.ResumeSignal();
        }

        public void PauseListener(object id)
        {
            signal.PauseListener(id);
        }

        public void ResumeListener(object id)
        {
            signal.ResumeListener(id);
        }
    }

    public abstract class ASignal : ABaseSignal
    {
        protected override ISignal signal => _signal;
        private GenericSignal _signal = new();

        public override void Destroy()
        {
            _signal.RemoveAllListeners();
            _signal = null;
        }

        public void AddListener(Action listener, int order = 0, object id = null)
        {
            _signal.AddListener(listener, order, id);
        }

        public void RemoveListener(Action listener)
        {
            _signal.RemoveListener(listener);
        }

        public void RemoveAllListeners()
        {
            _signal.RemoveAllListeners();
        }

        public void Dispatch()
        {
            _signal.Dispatch();
        }

        public void Dispatch(object id)
        {
            _signal.Dispatch(id);
        }
    }

    public abstract class ASignal<T> : ABaseSignal
    {
        protected override ISignal signal => _signal;
        private GenericSignal<T> _signal = new();

        public override void Destroy()
        {
            _signal.RemoveAllListeners();
            _signal = null;
        }

        public void AddListener(Action<T> listener, int order = 0, object id = null)
        {
            _signal.AddListener(listener, order, id);
        }

        public void RemoveListener(Action<T> listener)
        {
            _signal.RemoveListener(listener);
        }

        public void RemoveAllListeners()
        {
            _signal.RemoveAllListeners();
        }

        public void Dispatch(T arg1)
        {
            _signal.Dispatch(arg1);
        }

        public void Dispatch(object id, T arg1)
        {
            _signal.Dispatch(id, arg1);
        }
    }

    public abstract class ASignal<T, U> : ABaseSignal
    {
        protected override ISignal signal => _signal;
        private GenericSignal<T, U> _signal = new();

        public override void Destroy()
        {
            _signal.RemoveAllListeners();
            _signal = null;
        }

        public void AddListener(Action<T, U> listener, int order = 0, object id = null)
        {
            _signal.AddListener(listener, order, id);
        }

        public void RemoveListener(Action<T, U> listener)
        {
            _signal.RemoveListener(listener);
        }

        public void RemoveAllListeners()
        {
            _signal.RemoveAllListeners();
        }

        public void Dispatch(T arg1, U arg2)
        {
            _signal.Dispatch(arg1, arg2);
        }

        public void Dispatch(object id, T arg1, U arg2)
        {
            _signal.Dispatch(id, arg1, arg2);
        }
    }

    public abstract class ASignal<T, U, V> : ABaseSignal
    {
        protected override ISignal signal => _signal;
        private GenericSignal<T, U, V> _signal = new();

        public override void Destroy()
        {
            _signal.RemoveAllListeners();
            _signal = null;
        }

        public void AddListener(Action<T, U, V> listener, int order = 0, object id = null)
        {
            _signal.AddListener(listener, order, id);
        }

        public void RemoveListener(Action<T, U, V> listener)
        {
            _signal.RemoveListener(listener);
        }

        public void RemoveAllListeners()
        {
            _signal.RemoveAllListeners();
        }

        public void Dispatch(T arg1, U arg2, V arg3)
        {
            _signal.Dispatch(arg1, arg2, arg3);
        }

        public void Dispatch(object id, T arg1, U arg2, V arg3)
        {
            _signal.Dispatch(id, arg1, arg2, arg3);
        }
    }

    public abstract class ASignal<T, U, V, Y> : ABaseSignal
    {
        protected override ISignal signal => _signal;
        private GenericSignal<T, U, V, Y> _signal = new();

        public override void Destroy()
        {
            _signal.RemoveAllListeners();
            _signal = null;
        }

        public void AddListener(Action<T, U, V, Y> listener, int order = 0, object id = null)
        {
            _signal.AddListener(listener, order, id);
        }

        public void RemoveListener(Action<T, U, V, Y> listener)
        {
            _signal.RemoveListener(listener);
        }

        public void RemoveAllListeners()
        {
            _signal.RemoveAllListeners();
        }

        public void Dispatch(T arg1, U arg2, V arg3, Y arg4)
        {
            _signal.Dispatch(arg1, arg2, arg3, arg4);
        }

        public void Dispatch(object id, T arg1, U arg2, V arg3, Y arg4)
        {
            _signal.Dispatch(id, arg1, arg2, arg3, arg4);
        }
    }

    public abstract class ASignal<T, U, V, Y, Z> : ABaseSignal
    {
        protected override ISignal signal => _signal;
        private GenericSignal<T, U, V, Y, Z> _signal = new();

        public override void Destroy()
        {
            _signal.RemoveAllListeners();
            _signal = null;
        }

        public void AddListener(Action<T, U, V, Y, Z> listener, int order = 0, object id = null)
        {
            _signal.AddListener(listener, order, id);
        }

        public void RemoveListener(Action<T, U, V, Y, Z> listener)
        {
            _signal.RemoveListener(listener);
        }

        public void RemoveAllListeners()
        {
            _signal.RemoveAllListeners();
        }

        public void Dispatch(T arg1, U arg2, V arg3, Y arg4, Z arg5)
        {
            _signal.Dispatch(arg1, arg2, arg3, arg4, arg5);
        }

        public void Dispatch(object id, T arg1, U arg2, V arg3, Y arg4, Z arg5)
        {
            _signal.Dispatch(id, arg1, arg2, arg3, arg4, arg5);
        }
    }
}
