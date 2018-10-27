using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PublishSite.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string ImageUrlAvatar { get; set; }
    }
}