namespace DecimusN7.Sandbox.ApplicationUser
{
    /// <summary>
    /// Class describing the properties and methods of an application user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the user's <see cref="int"/> id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user's <see cref="string"/> last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user's <see cref="string"/> first name.
        /// </summary>
        public string FirstName { get; set; }
    }
}
