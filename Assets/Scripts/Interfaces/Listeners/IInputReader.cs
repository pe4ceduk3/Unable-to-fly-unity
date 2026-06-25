using System;
namespace Interfaces.Listeners
{
    public interface IInputReader
    {
        public event Action OnShot;
    }
}