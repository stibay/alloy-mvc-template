﻿using System.Web;
using System.Web.WebPages;
using EPiServer.Web;

namespace AlloyTemplates.Business.Channels
{
    //<summary>
    //Defines the 'Mobile' content channel
    //</summary>
    public class MobileChannel : DisplayChannel
    {
        public const string Name = "mobile";

        public override string ChannelName => Name;

        public override string ResolutionId => typeof(IphoneVerticalResolution).FullName;

        public override bool IsActive(HttpContextBase context)
        {
            return context.GetOverriddenBrowser().IsMobileDevice;
        }
    }
}
