using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTemplates.Models.Blocks
{
    /// <summary>
    /// Used to present contact information with a call-to-action link
    /// </summary>
    /// <remarks>Actual contact details are retrieved from a contact page specified using the ContactPageLink property</remarks>
    [SiteContentType(GUID = "7E932EAF-6BC2-4753-902A-8670EDC5F363")]
    [SiteImageUrl]
    public class ContactBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(Order = 20)]
        public virtual string Heading { get; set; }

        /// <summary>
        /// Gets or sets the contact page from which contact information should be retrieved
        /// </summary>
        [Display(Order = 30)]
        [UIHint(Global.SiteUIHints.Contact)]
        public virtual PageReference ContactPageLink { get; set; }

        [CultureSpecific]
        [Display(Order = 40)]
        public virtual string LinkText { get; set; }

        [CultureSpecific]
        [Display(Order = 50)]
        public virtual Url LinkUrl { get; set; }
    }
}
