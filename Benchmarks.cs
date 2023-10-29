using BenchmarkDotNet.Attributes;

namespace benchmarks_dotnet;

public class Benchmarks
{
    private const string String = "value";
    private const string EmptyString = "";
    private const string Null = null;
    private static readonly UnderTest UnderTest = new();

    [Benchmark]
    public void Microsoft_ArgumentNullException_ThrowIfNull_InvokedWithString()
    {
        UnderTest.Microsoft_ArgumentNullException_ThrowIfNull(String);
    }

    [Benchmark]
    public void Microsoft_ArgumentNullException_ThrowIfNull_InvokedWithNullString()
    {
        UnderTest.Microsoft_ArgumentNullException_ThrowIfNull(Null);
    }

    [Benchmark]
    public void Microsoft_ArgumentException_ThrowIfNullOrEmpty_InvokedWithEmptyString()
    {
        UnderTest.Microsoft_ArgumentException_ThrowIfNullOrEmpty(EmptyString);
    }

    [Benchmark]
    public void JetBrains_CoalescingOperator_InvokedWithString()
    {
        UnderTest.JetBrains_CoalescingOperator(String);
    }

    [Benchmark]
    public void JetBrains_CoalescingOperator_InvokedWithNullString()
    {
        UnderTest.JetBrains_CoalescingOperator(Null);
    }
}