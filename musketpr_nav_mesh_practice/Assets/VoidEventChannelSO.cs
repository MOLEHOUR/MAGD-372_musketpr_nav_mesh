using UnityEngine;
[CreateAssetMenu(fileName = "newVoidEvent", menuName = "VoidEventChannelSO")]
public class VoidEventChannelSO : ScriptableObject
{
    public delegate void VoidEvent();
    public static event VoidEvent OnRaisedEvent;
    public void RaisedEvent()
    {
        OnRaisedEvent?.Invoke();
    }
}
