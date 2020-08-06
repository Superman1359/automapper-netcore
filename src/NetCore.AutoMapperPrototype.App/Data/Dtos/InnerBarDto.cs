﻿using System.ComponentModel.DataAnnotations;

namespace NetCore.AutoMapperPrototype.App.Data.Dtos
{
    public sealed class InnerBarDto
    {
        [Required]
        [MaxLength(100)]
        public string Value { get; set; }
    }
}
