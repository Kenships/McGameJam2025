using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "GenericEventChannelSO", menuName = "Scriptable Objects/GenericEventChannelSO")]
public abstract class GenericEventChannelSO<T> : ScriptableObject
{
    [Tooltip("Assign event to this channel | added subscribers will be invoked.")]
    public UnityAction<T> onEventRaised;

    public void RaiseEvent(T type)
    {
        onEventRaised?.Invoke(type);
    }
}
