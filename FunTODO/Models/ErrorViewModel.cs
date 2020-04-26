using FunTODOWebSite.Models;
using System;

namespace FunTODO.Models
{
    public class ErrorViewModel: IApplicationModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
