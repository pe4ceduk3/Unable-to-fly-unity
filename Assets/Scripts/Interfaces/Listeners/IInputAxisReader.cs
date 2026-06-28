using System;

namespace Interfaces.Listeners
{
    public interface IInputAxisReader
    {
        event Action<float> OnAxisChanged;
    }
}