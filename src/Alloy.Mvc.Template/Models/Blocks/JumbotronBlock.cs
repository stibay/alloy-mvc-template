using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTemplates.Models.Blocks
{
    /// <summary>
    /// Used for a primary message on a page, commonly used on start pages and landing pages
    /// </summary>
    [SiteContentType(
        GroupName = Global.GroupNames.Specialized,
        GUID = "9FD1C860-7183-4122-8CD4-FF4C55E096F9")]
    [SiteImageUrl]
    public class JumbotronBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        /// <summary>
        /// Gets or sets a description for the image, for example used as the alt text for the image when rendered
        /// </summary>
        [CultureSpecific]
        [Display(Order = 20)]
        [UIHint(UIHint.Textarea)]
        public virtual string ImageDescription
        {
            get
            {
                var propertyValue = this["ImageDescription"] as string;

                // Return image description with fall back to the heading if no description has been specified
                return string.IsNullOrWhiteSpace(propertyValue) ? Heading : propertyValue;
            }
            set { this["ImageDescription"] = value; }
        }

        [CultureSpecific]
        [Display(Order = 30)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Order = 40)]
        [UIHint(UIHint.Textarea)]
        public virtual string SubHeading { get; set; }

        [Required]
        [CultureSpecific]
        [Display(Order = 50)]
        public virtual string ButtonText { get; set; }

        //The link must be required as an anchor tag requires an href in order to be valid and focusable
        [Required]
        [CultureSpecific]
        [Display(Order = 60)]
        public virtual Url ButtonLink { get; set; }
    }
}
