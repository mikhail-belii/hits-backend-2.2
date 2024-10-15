﻿using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.Comment;

public class CommentCreateModel
{
    [Required]
    [MinLength(1)]
    [MaxLength(1000)]
    public string Content { get; set; }
    public Guid? ParentId { get; set; }
}