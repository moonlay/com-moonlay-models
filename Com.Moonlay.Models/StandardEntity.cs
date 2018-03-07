﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Moonlay.Models
{
    public abstract class StandardEntity<TKey> : BaseEntity<TKey>, IActive, IAuditEntity, ISoftEntity
    {
        public bool Active { get; set; }

        public DateTime CreatedUtc { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAgent { get; set; }

        public DateTime LastModifiedUtc { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAgent { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime DeletedUtc { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedAgent { get; set; }

    }

    public abstract class StandardEntity : StandardEntity<int>
    {

    }
}
