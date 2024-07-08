using BlazorApp2.Server.Service;
using BlazorApp2.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp2.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TreeController : ControllerBase
{
    private readonly TreeService _treeService;

    public TreeController(TreeService treeService)
    {
        _treeService = treeService;
    }

    [HttpGet]
    public ActionResult<TreeNode<string>> GetTree()
    {
        return _treeService.CreateSampleTree();
    }
}