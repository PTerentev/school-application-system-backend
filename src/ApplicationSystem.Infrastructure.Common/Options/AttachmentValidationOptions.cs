﻿namespace ApplicationSystem.Infrastructure.Common.Options
{
    /// <summary>
    /// Attachment validation options.
    /// </summary>
    public class AttachmentValidationOptions
    {
        /// <summary>
        /// Configuration section name.
        /// </summary>
        public const string Name = "AttachmentValidation";

        /// <summary>
        /// Number of allowed attachments.
        /// </summary>
        public int NumberOfAllowedAttachments { get; set; }

        /// <summary>
        /// Allowed file size in megabytes.
        /// </summary>
        public int AllowedFileSizeInMegabytes { get; set; }
    }
}
