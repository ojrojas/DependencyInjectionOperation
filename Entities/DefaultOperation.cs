namespace DependencyInjectionOperation.Entities;

public class DefaultOperation :  ISingletonOperation, ITransientOperation, IScopedOperation
{
    public string OperationId => Guid.NewGuid().ToString();
}