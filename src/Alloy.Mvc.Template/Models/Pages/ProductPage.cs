﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AlloyTemplates.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using AlloyTemplates.Models.Properties;

namespace AlloyTemplates.Models.Pages
{
    /// <summary>
    /// Used to present a single product
    /// </summary>
    [SiteContentType(
        GUID = "17583DCD-3C11-49DD-A66D-0DEF0DD601FC",
        GroupName = Global.GroupNames.Products)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    [AvailableContentTypes(
        Availability = Availability.Specific,
        IncludeOn = new[] { typeof(StartPage) })]
    public class ProductPage : StandardPage, IHasRelatedContent
    {
        [Required]
        [CultureSpecific]
        [Display(Order = 305)]
        [UIHint(Global.SiteUIHints.StringsCollection)]
        public virtual IList<string> UniqueSellingPoints { get; set; }

        [CultureSpecific]
        [Display(Order = 330)]
        [AllowedTypes(new[] { typeof(IContentData) },new[] { typeof(JumbotronBlock) })]
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}
