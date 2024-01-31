

namespace PartsClient.Data;

public class RefreshMessage : ValueChangedMessage<bool>
{
    public RefreshMessage(bool value) : base(value)
    {
    }
}

public class ValueChangedMessage<T>
{
    private bool value;

    public ValueChangedMessage(bool value)
    {
        this.value = value;
    }
}