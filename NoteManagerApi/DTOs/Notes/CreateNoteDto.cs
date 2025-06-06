﻿using System.ComponentModel.DataAnnotations;

namespace NoteManagerApi.DTOs.Notes;

public class CreateNoteDto
{
    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    public string Description { get; set; }
}