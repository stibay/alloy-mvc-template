using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using AlloyTemplates.Business.Rendering;
using AlloyTemplates.Models.Properties;
using EPiServer.Web;

namespace AlloyTemplates.Models.Pages
{
    /// <summary>
    /// Base class for all page types
    /// </summary>
    public abstract class SitePageData : PageData, ICustomCssInContentArea
    {
        [CultureSpecific]
        [Display(GroupName = Global.GroupNames.MetaData, Order = 100)]
        public virtual string MetaTitle
        {
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);

                // Use explicitly set meta title, otherwise fall back to page name
                return !string.IsNullOrWhiteSpace(metaTitle)
                        ? metaTitle
                        : PageName;
            }
            set { this.SetPropertyValue(p => p.MetaTitle, value); }
        }

        [CultureSpecific]
        [Display(GroupName = Global.GroupNames.MetaData, Order = 200)]
        [BackingType(typeof(PropertyStringList))]
        public virtual string[] MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(GroupName = Global.GroupNames.MetaData, Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

        [CultureSpecific]
        [Display(GroupName = Global.GroupNames.MetaData, Order = 400)]
        public virtual bool DisableIndexing { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Order = 100)]
        public virtual ContentReference PageImage { get; set; }

        [CultureSpecific]
        [Display(Order = 200)]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText
        {
            get
            {
                var teaserText = this.GetPropertyValue(p => p.TeaserText);

                // Use explicitly set teaser text, otherwise fall back to description
                return !string.IsNullOrWhiteSpace(teaserText) ? teaserText : MetaDescription;
            }
            set { this.SetPropertyValue(p => p.TeaserText, value); }
        }

        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Settings, Order = 200)]
        public virtual bool HideSiteHeader { get; set; }

        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Settings, Order = 300)]
        public virtual bool HideSiteFooter { get; set; }

        public string ContentAreaCssClass => "teaserblock";
    }
}
