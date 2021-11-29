using System.ComponentModel.DataAnnotations;
using EPiServer;

namespace AlloyTemplates.Models.Blocks
{
    /// <summary>
    /// Used to insert a link which is styled as a button
    /// </summary>
    [SiteContentType(GUID = "426CF12F-1F01-4EA0-922F-0778314DDAF0")]
    [SiteImageUrl]
    public class ButtonBlock : SiteBlockData
    {
        [Required]
        [Display(Order = 10)]
        public virtual string ButtonText { get; set; }

        [Required]
        [Display(Order = 20)]
        public virtual Url ButtonLink { get; set; }
    }
}
