using UnityEngine.Events;

public class ObservableValue<T>
{
    private T _value;
    private UnityEvent<T> _onValueChanged;

    public ObservableValue(T value)
    {
        _value = value;
        _onValueChanged = new UnityEvent<T>();
    }

    public T Value
    {
        get { return _value; }
        set { _value = value; _onValueChanged.Invoke(value); }
    }

    public void AddListener(UnityAction<T> action)
    {
        _onValueChanged.AddListener(action);
    }
    public void RemoveListener(UnityAction<T> action)
    {
        _onValueChanged.RemoveListener(action);
    }
}
