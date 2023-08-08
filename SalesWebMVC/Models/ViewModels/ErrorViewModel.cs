using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SalesWebMVC.Models.ViewModels
{
    public class ErrorViewModel

    {
        [Key]

        public string RequestId { get; set; }

        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}