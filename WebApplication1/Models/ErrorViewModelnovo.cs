using System;

namespace WebApplication1.Models
{
    public class ErrorViewModelnovo
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}