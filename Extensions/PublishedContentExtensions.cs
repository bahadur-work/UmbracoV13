using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoV13.Extensions
{
public static class PublishedContentExtensions 
{
    public static HomePage? GetHomePage(this IPublishedContent publishedContent)
    {
        return publishedContent.AncestorOrSelf<HomePage>();

    }
    public static SiteSettings? GetSiteSettings(this IPublishedContent PublishedContent){
        var HomePage = GetHomePage(PublishedContent);
        if(HomePage == null) return null;
        return HomePage.FirstChild<SiteSettings>();
    }
}
}