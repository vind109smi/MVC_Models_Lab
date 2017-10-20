using System;


namespace MVCLab5.Models
{
    public class ErrorCatchingModel
    {
        public string GetId { get; set; }

        public bool ShowGetId => !string.IsNullOrEmpty(GetId);
    }
}
