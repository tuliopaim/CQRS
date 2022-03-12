﻿using Microsoft.AspNetCore.Mvc;
using MSBase.Cadastro.API.Commands.EditarPessoaCommand;
using MSBase.Cadastro.API.Commands.NovaPessoaCommand;
using MSBase.Cadastro.API.Queries.ObterPessoasQuery;
using MSBase.Cadastro.API.Requests;
using MSBase.Core.API;
using MSBase.Core.API.Hateoas;
using MSBase.Core.Application.Mediator;

namespace MSBase.Cadastro.API.Controllers
{
    [Route("/v1/pessoa")]
    public class PessoaController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IHateoasHelper _heateoasHelper;

        public PessoaController(
            IMediator mediator,
            IHateoasHelper heateoasHelper)
        {
            _mediator = mediator;
            _heateoasHelper = heateoasHelper;
        }

        [HttpGet(Name = nameof(ObterPessoas))]
        public async Task<IActionResult> ObterPessoas([FromQuery] ObterPessoasQueryInput input, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(input, cancellationToken);

            result.Links = _heateoasHelper.CreatePaginatedHLinks(
                nameof(ObterPessoas),
                input,
                result.Pagination);

            return HandleMediatorResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] NovaPessoaRequest request, CancellationToken cancellationToken)
        {
            var command = new NovaPessoaCommandInput(request.Nome, request.Email, request.Idade);

            var result = await _mediator.Send(command, cancellationToken);

            return HandleMediatorResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] EditarPessoaRequest request, CancellationToken cancellationToken)
        {
            var command = new EditarPessoaCommandInput(request.PessoaId, request.NovaIdade);

            var result = await _mediator.Send(command, cancellationToken);

            return HandleMediatorResult(result);
        }
    }
}