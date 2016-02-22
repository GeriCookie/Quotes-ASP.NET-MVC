namespace Quotes.Data.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections;
    using System.Collections.Generic;    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        private ICollection<Favorite> favorites;
        private ICollection<ApplicationUser> following;
        private ICollection<Update> updates;
        private ICollection<Comment> comments;

        public ApplicationUser()
        {
            this.favorites = new HashSet<Favorite>();
            this.following = new HashSet<ApplicationUser>();
            this.updates = new HashSet<Update>();
            this.comments = new HashSet<Comment>();
        }

        public virtual ICollection<Favorite> Favorites
        {
            get
            {
                return this.favorites;
            }

            set
            {
                this.favorites = value;
            }
        } 

        public virtual ICollection<ApplicationUser> Following
        {
            get
            {
                return this.following;
            }

            set
            {
                this.following = value;
            }
        }

        public virtual ICollection<Update> Updates
        {
            get
            {
                return this.updates;
            }

            set
            {
                this.updates = value;
            }
        }

        public virtual ICollection<Comment> Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                this.comments = value;
            }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}
