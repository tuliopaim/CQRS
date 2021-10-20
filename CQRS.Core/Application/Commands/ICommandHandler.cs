﻿using System.Threading;
using System.Threading.Tasks;
using CQRS.Core.Application.Mediator;
using MediatR;

namespace CQRS.Core.Application.Commands
{
    public interface ICommandHandler<in TCommandInput, TCommandResult> : IMediatorHandler<TCommandInput, TCommandResult>
        where TCommandInput : IRequest<TCommandResult>, IMediatorInput<TCommandResult>
        where TCommandResult : IMediatorResult
    {
        new Task<TCommandResult> Handle(TCommandInput command, CancellationToken cancellationToken);
    }
}