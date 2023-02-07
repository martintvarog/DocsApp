using System.Xml.Serialization;
using Core.Entities;
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

        // if (Request.Headers["Accept"] == "application/xml")
        //     return Content(_documentService.ConvertDocumentXmlAsync(document.First().MapToDocument()).ToString());

        return Ok(document.First().MapToDocument());
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] DocumentDto document)
    {
        if (!await _documentService.AddDocumentAsync(document.MapToDocument()))
            return BadRequest();

        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] DocumentDto document)
    {
        if (!await _documentService.UpdateDocumentAsync(document.MapToDocument()))
            return NotFound();

        return Ok();
    }
}