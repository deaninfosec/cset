﻿using System.ComponentModel.DataAnnotations;

namespace CSETWebCore.Interfaces.AssessmentIO
{
    public interface IExternalDocument
    {
        [Required]
        string Name { get; set; }
        [Required]
        string ShortName { get; set; }
        byte[] Data { get; set; }
        double? FileSize { get; set; }
        string FileName { get; set; }
    }
}