namespace benchmarks_dotnet;

public class UnderTest
{
    private string _param;

    public void Microsoft_ArgumentNullException_ThrowIfNull(string param)
    {
        ArgumentNullException.ThrowIfNull(param);
        _param = param;
    }

    public void Microsoft_ArgumentException_ThrowIfNullOrEmpty(string param)
    {
        ArgumentException.ThrowIfNullOrEmpty(param);
        _param = param;
    }

    public void JetBrains_CoalescingOperator(string param)
    {
        _param = param ?? throw new ArgumentNullException(nameof(param));
    }
}