using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NullJsonTest.Models
{
    public class Settings
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("category")]
        public int Category { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("value")]
        public string? Value { get; set; }

        [Column("type_id")]
        public int TypeId { get; set; }
    }
}