using System.Diagnostics.CodeAnalysis;

// Simple assertions
public static class Assert
{
    public static void True([DoesNotReturnIf(false)] bool condition, string message)
    {
        if (!condition)
        {
            throw new Exception(message);
        }
    }

    public static void SameObject(object? left, object? right, string message)
    {
        Assert.True(object.ReferenceEquals(left, right), message);
    }

    public static void NotSameObject(object? left, object? right, string message)
    {
        Assert.True(!object.ReferenceEquals(left, right), message);
    }

    public static void Fail(string message)
    {
        throw new Exception(message);
    }

    public static void Throws<TException>(Action callback) where TException : Exception
    {
        try
        {
            callback();
            Assert.Fail("Expected exception of type: " + typeof(TException).FullName);
        }
        catch (TException)
        {
        }
    }
}
