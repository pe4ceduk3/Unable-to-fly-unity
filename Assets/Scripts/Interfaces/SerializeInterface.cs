using System;
using UnityEngine;

/* How to use
 *
 * Object should be [System.Serializable]
 *
 * ---
 *
 * //Serialize Object
 * 
 *  [SerializeField]  SerializeInterface<ISpeedData> speedData; //speedData.Value
 *
 * ---
 *
 * //Serialize Struct.Data
 * 
 *  [SerializeField] private SerializeInterface<IState> state;
 * 
 *  public IState State
 *  { 
 *      get => state.Value; 
 *      set => state = new SerializeInterface<IState>(value as UnityEngine.Object); 
 *  }
 *
 * ---
 *
 * //Serialize Array[]
 *
 *  using System.Linq;
 * 
 *  [SerializeField] private SerializeInterface<IStateContext>[] nextStatesOnExit;
 *
 *  public IStateContext[] NextStatesOnExit
 *  {
 *      get => nextStatesOnExit?.Select(s => s.Value).ToArray();
 *      set => nextStatesOnExit = value?
 *          .Select(v => new SerializeInterface<IStateContext>(v as UnityEngine.Object))
 *          .ToArray();
 *  }
 * 
 */

namespace Interfaces
{
    [Serializable]
    public struct SerializeInterface<TInterface> where TInterface : class
    {
        [SerializeField] private UnityEngine.Object underlyingObject;
        
        public SerializeInterface(UnityEngine.Object obj) => underlyingObject = obj;

        public TInterface Value
        {
            get
            {
                if (underlyingObject == null) return null;
                if (underlyingObject is TInterface @interface) return @interface;
                if (underlyingObject is GameObject go) return go.GetComponent<TInterface>();
                return null;
            }
        }
    }
}
