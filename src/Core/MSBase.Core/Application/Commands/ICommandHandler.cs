﻿using MediatR;
using MSBase.Core.Application.Mediator;

namespace MSBase.Core.Application.Commands
{
    public interface ICommandHandler<in TCommandInput, TCommandResult> : IMediatorHandler<TCommandInput, TCommandResult>
        where TCommandInput : IRequest<TCommandResult>, IMediatorInput<TCommandResult>
        where TCommandResult : IMediatorResult
    {
        new Task<TCommandResult> Handle(TCommandInput command, CancellationToken cancellationToken);
    }
}