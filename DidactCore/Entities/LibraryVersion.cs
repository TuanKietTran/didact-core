﻿using System;

namespace DidactCore.Entities
{
    public class LibraryVersion
    {
        public long LibraryVersionId { get; set; }

        public long LibraryId { get; set; }

        public int OrganizationId { get; set; }

        public string AssemblyVersion { get; set; } = null!;

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime LastUpdated { get; set; }

        public string LastUpdatedBy { get; set; } = null!;

        public bool Active { get; set; }

        public byte[] RowVersion { get; set; } = null!;
    }
}
