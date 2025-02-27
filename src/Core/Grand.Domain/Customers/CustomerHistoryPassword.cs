﻿namespace Grand.Domain.Customers
{
    /// <summary>
    /// Represents a Customer History Password
    /// </summary>
    public partial class CustomerHistoryPassword : BaseEntity
    {
        public CustomerHistoryPassword()
        {
            PasswordFormatId = PasswordFormat.Clear;
        }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the password format identifier
        /// </summary>
        public PasswordFormat PasswordFormatId { get; set; }

        /// <summary>
        /// Gets or sets the password salt
        /// </summary>
        public string PasswordSalt { get; set; }

    }
}
