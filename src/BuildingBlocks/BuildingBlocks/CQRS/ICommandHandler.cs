using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface ICommandHandler<in TComand>
        : ICommandHandler<TComand, Unit>
        where TComand : ICommand<Unit>        
    {
    }

    public interface ICommandHandler<in TComand, TResponse> 
        : IRequestHandler<TComand, TResponse>
        where TComand : ICommand<TResponse>
        where TResponse : notnull
    {
    }
}
