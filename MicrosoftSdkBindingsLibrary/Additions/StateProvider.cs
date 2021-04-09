using System;

namespace Sample.Androidlibrary
{
    public abstract partial class StateProvider
    {
        public static StateFlag[] GetAllStates()
        {
            return new[]
            {
                StateFlag.On,
                StateFlag.Off,
                StateFlag.Superposition,
                StateFlag.Unknown,
            };
        }
        
        public StateFlag SafeState
        {
            get
            {
                try
                {
                    return State;
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                try
                {
                    State = value;
                }
                catch 
                {
                }
            }
        }
    }
}