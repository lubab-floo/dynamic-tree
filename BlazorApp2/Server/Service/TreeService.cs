using BlazorApp2.Shared;

namespace BlazorApp2.Server.Service;

public class TreeService
{
    public TreeNode<string> CreateSampleTree()
    {
        var root = new TreeNode<string>("Root");
        var child1 = new TreeNode<string>("Child 1");
        var child2 = new TreeNode<string>("Child 2");
        var child11 = new TreeNode<string>("Child 1.1");

        root.Children.Add(child1);
        root.Children.Add(child2);

        child1.Children.Add(child11);
        child1.Children.Add(new TreeNode<string>("Child 1.2"));

        child2.Children.Add(new TreeNode<string>("Child 2.1"));

        child11.Children.Add(new TreeNode<string>("Child 1.1.1"));
        child11.Children.Add(new TreeNode<string>("Child 1.1.2"));
        
        return root;
    }
}