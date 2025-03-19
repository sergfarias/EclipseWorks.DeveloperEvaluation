using MediatR;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Application.Sales.ModifiedSale;
using Ambev.DeveloperEvaluation.Application.Sales.CancelledSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.ModifiedSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSale;
using Ambev.DeveloperEvaluation.Application.Sales.CancelledSaleItem;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledItemSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSaleItem;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales;

/// <summary>
/// Controller for managing sale operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class SalesController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of UsersController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public SalesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Creates a new sale
    /// </summary>
    /// <param name="request">The sale creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sale details</returns>
    [HttpPost("CreateSale")]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateSaleResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateSale([FromBody] CreateSaleRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreateSaleRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CreateSaleCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreateSaleResponse>
        {
            Success = true,
            Message = "Sale created successfully",
            Data = _mapper.Map<CreateSaleResponse>(response)
        });
    }

    /// <summary>
    /// Modified a sale
    /// </summary>
    /// <param name="request">The sale Modified request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The Modified sale details</returns>
    [HttpPut("ModifiedSale")]
    [ProducesResponseType(typeof(ApiResponseWithData<ModifiedSaleResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> ModifiedSale([FromBody] ModifiedSaleRequest request, CancellationToken cancellationToken)
    {
        var validator = new ModifiedSaleRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<ModifiedSaleCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<ModifiedSaleResponse>
        {
            Success = true,
            Message = "Sale modified successfully",
            Data = _mapper.Map<ModifiedSaleResponse>(response)
        });
    }


    /// <summary>
    /// Cancelled a sale
    /// </summary>
    /// <param name="request">The sale Cancelled request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The Cancelled sale details</returns>
    [HttpPut("CancelledSale")]
    [ProducesResponseType(typeof(ApiResponseWithData<CancelledSaleResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CancelledSale([FromBody] CancelledSaleRequest request, CancellationToken cancellationToken)
    {
        var validator = new CancelledSaleRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CancelledSaleCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CancelledSaleResponse>
        {
            Success = true,
            Message = "Sale cancelled successfully",
            Data = _mapper.Map<CancelledSaleResponse>(response)
        });
    }

    /// <summary>
    /// Cancelled a sale item
    /// </summary>
    /// <param name="request">The sale Cancelled request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The Cancelled sale details</returns>
    [HttpPut("CancelledSaleItem")]
    [ProducesResponseType(typeof(ApiResponseWithData<CancelledSaleItemResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CancelledSaleItem([FromBody] CancelledSaleItemRequest request, CancellationToken cancellationToken)
    {
        var validator = new CancelledSaleItemRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CancelledSaleItemCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CancelledSaleItemResponse>
        {
            Success = true,
            Message = "Sale cancelled successfully",
            Data = _mapper.Map<CancelledSaleItemResponse>(response)
        });
    }

}
