using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace AlloyTemplates.Models.Blocks
{
    /// <summary>
    /// Used to insert editorial content edited using a rich-text editor
    /// </summary>
    [SiteContentType(GUID = "67F617A4-2175-4360-975E-75EDF2B924A7")]
    [SiteImageUrl]
    public class EditorialBlock : SiteBlockData
    {
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }
    }
}
