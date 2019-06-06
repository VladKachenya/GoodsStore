namespace GoodsStore.Core.Domain.Identity
{
    public interface IUser
    {
        /// <summary>Gets or sets the primary key for this user.</summary>
        string Id { get; set; }

        /// <summary>Gets or sets the user name for this user.</summary>
        string UserName { get; set; }

        /// <summary>Gets or sets the email address for this user.</summary>
        string Email { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if a user has confirmed their email address.
        /// </summary>
        /// <value>True if the email address has been confirmed, otherwise false.</value>
        bool EmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets a salted and hashed representation of the password for this user.
        /// </summary>
        string PasswordHash { get; set; }


        /// <summary>Gets or sets a telephone number for the user.</summary>
        string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if a user has confirmed their telephone address.
        /// </summary>
        /// <value>True if the telephone number has been confirmed, otherwise false.</value>
        bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if two factor authentication is enabled for this user.
        /// </summary>
        /// <value>True if 2fa is enabled, otherwise false.</value>

        bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Gets or sets the number of failed login attempts for the current user.
        /// </summary>
        int AccessFailedCount { get; set; }
    }
}