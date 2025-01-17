﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CSETWebCore.DataLayer.Model
{
    /// <summary>
    /// A collection of FINANCIAL_REQUIREMENTS records
    /// </summary>
    public partial class FINANCIAL_REQUIREMENTS
    {
        [Key]
        public int StmtNumber { get; set; }
        [Key]
        public int Requirement_Id { get; set; }
        public int? maturity_question_id { get; set; }

        [ForeignKey(nameof(Requirement_Id))]
        [InverseProperty(nameof(NEW_REQUIREMENT.FINANCIAL_REQUIREMENTS))]
        public virtual NEW_REQUIREMENT Requirement { get; set; }
        [ForeignKey(nameof(StmtNumber))]
        [InverseProperty(nameof(FINANCIAL_DETAILS.FINANCIAL_REQUIREMENTS))]
        public virtual FINANCIAL_DETAILS StmtNumberNavigation { get; set; }
    }
}