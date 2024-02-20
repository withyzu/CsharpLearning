using System.ComponentModel.DataAnnotations;

namespace DemoDeploySite.Models;
public class SiteInfo {

    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = "不试试你怎么知道~ 😋";

    public int Start { get; set; }

    public int ClickCount { get; set; }

}
