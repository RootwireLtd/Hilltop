using Rootwire.Hilltop.Domain.Common;

namespace Rootwire.Hilltop.Domain.Entities.Test;

public class Category : BaseAuditableEntity
{
    /// <summary>
    /// The name of the Category.
    /// EG: Firewalls
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Additional information about the category
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// The Parent Category
    /// EG: CyberSecurity
    /// </summary>
    public Category ParentCategory { get; set; }
}