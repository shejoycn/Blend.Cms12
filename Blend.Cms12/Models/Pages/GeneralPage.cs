using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Pages
{

}
namespace Blend.Cms12.Models.Pages
{
    [ContentType(
        DisplayName = "General Page",
        Description = "General Page",
        GUID = "9dabbc01-e5c2-49fc-afe8-949e1fd4eb60",
        GroupName = "General Content"
     )]
    public class GeneralPage : AbstractContentPage
    {


        [Display(
            Name = "Headline",
             GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual string? Headline { get; set; }


        [Display(
        Name = "Headline Slug",
         GroupName = SystemTabNames.Content,
        Order = 20
        )]
        public virtual string? HeadlineSlug { get; set; }


        [Display(
        Name = "Body",
         GroupName = SystemTabNames.Content,
        Order = 30
        )]
        public virtual XhtmlString? Body { get; set; }
    }
}