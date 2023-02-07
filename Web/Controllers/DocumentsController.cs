using Core.Infrastructure;
using Core.Infrastructure.DTOs;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DocsApp.Controllers;

[ApiController]
[Route("[controller]")]
public class DocumentsController : ControllerBase
{
    private readonly IDocumentService _documentService;

    public DocumentsController(IDocumentService documentService)
    {
        _documentService = documentService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var document = await _documentService.GetDocumentByIdAsync(id);
        if (!document.Any())
            return NotFound();

        return Ok(document.First().MapToDocument());
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] DocumentDto document)
    {
        if (!await _documentService.AddDocumentAsync(document))
            return BadRequest();

        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] DocumentDto document)
    {
        if (!await _documentService.UpdateDocumentAsync(document))
            return NotFound();

        return Ok();
    }
}