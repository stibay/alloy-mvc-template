using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Filters;

namespace AlloyTemplates.Models.Blocks
{
    /// <summary>
    /// Used to insert a list of pages, for example a news list
    /// </summary>
    [SiteContentType(GUID = "30685434-33DE-42AF-88A7-3126B936AEAD")]
    [SiteImageUrl]
    public class PageListBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(Order = 10)]
        public virtual string Heading { get; set; }

        [DefaultValue(false)]
        [Display(Order = 20)]
        public virtual bool IncludePublishDate { get; set; }

        /// <summary>
        /// Gets or sets whether a page introduction/description should be included in the list
        /// </summary>
        [DefaultValue(true)]
        [Display(Order = 30)]
        public virtual bool IncludeIntroduction { get; set; }

        [Required]
        [DefaultValue(3)]
        [Display(Order = 40)]
        public virtual int Count { get; set; }

        [Display(Order = 50)]
        [UIHint("SortOrder")]
        [BackingType(typeof(PropertyNumber))]
        [DefaultValue(FilterSortOrder.PublishedDescending)]
        public virtual FilterSortOrder SortOrder { get; set; }

        [Required]
        [Display(Order = 60)]
        public virtual PageReference Root { get; set; }

        [Display(Order = 70)]
        public virtual PageType PageTypeFilter{get; set;}

        [Display(Order = 80)]
        public virtual CategoryList CategoryFilter { get; set; }

        [Display(Order = 90)]
        public virtual bool Recursive { get; set; }

        /// <summary>
        /// Sets the default property values on the content data.
        /// </summary>
        /// <param name="contentType">Type of the content.</param>
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            Count = 3;
            IncludeIntroduction = true;
            IncludePublishDate = false;
            SortOrder = FilterSortOrder.PublishedDescending;
        }
    }
}
