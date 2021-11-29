using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTemplates.Models.Blocks
{
    /// <summary>
    /// Used to provide a stylized entry point to a page on the site
    /// </summary>
    [SiteContentType(GUID = "EB67A99A-E239-41B8-9C59-20EAA5936047")] // BEST PRACTICE TIP: Always assign a GUID explicitly when creating a new block type
    [SiteImageUrl] // Use site's default thumbnail
    public class TeaserBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(Order = 10)]
        [Required(AllowEmptyStrings = false)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Order = 20)]
        [UIHint(UIHint.Textarea)]
        [Required(AllowEmptyStrings = false)]
        public virtual string Text { get; set; }

        [CultureSpecific]
        [Display(Order = 30)]
        [UIHint(UIHint.Image)]
        [Required(AllowEmptyStrings = false)]
        public virtual ContentReference Image { get; set; }

        [Display(Order = 40)]
        public virtual PageReference Link { get; set; }
    }
}
