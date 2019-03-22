using BibliTech.Common.Razor.Services.WebSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliTech.Cleaner.Web.Models
{

    public class CleanerWebSettings : DefaultWebSettings
    {

        public FacebookSettings Facebook { get; set; }

        public class FacebookSettings
        {
            public string AppId { get; set; }
        }

    }

}
