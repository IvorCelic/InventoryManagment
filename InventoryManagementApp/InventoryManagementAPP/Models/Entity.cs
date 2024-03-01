﻿using System.ComponentModel.DataAnnotations;

namespace InventoryManagementAPP.Models
{
    /// <summary>
    /// Represents the top-level base class containing fundamental attributes such as code, operator, entry date, changes, etc.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Gets or sets the primary key attribute in the database with generating value identities (1, 1).
        /// </summary>
        [Key]
        public int? Id { get; set; }
    }
}
