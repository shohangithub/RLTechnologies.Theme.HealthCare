using System.Collections.Generic;
using Oqtane.Models;
using Oqtane.Themes;
using Oqtane.Shared;
using System.Resources;

namespace RLTechnologies.Theme.HealthCare
{
    public class ThemeInfo : ITheme
    {
        public Oqtane.Models.Theme Theme => new Oqtane.Models.Theme
        {
            Name = "RLTechnologies HealthCare",
            Version = "1.0.0",
            PackageName = "RLTechnologies.Theme.HealthCare",
            ThemeSettingsType = "RLTechnologies.Theme.HealthCare.ThemeSettings, RLTechnologies.Theme.HealthCare.Client.Oqtane",
            ContainerSettingsType = "RLTechnologies.Theme.HealthCare.ContainerSettings, RLTechnologies.Theme.HealthCare.Client.Oqtane",
            
            Resources = new List<Resource>()
            {
		        // obtained from https://cdnjs.com/libraries
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.3/css/bootstrap.min.css", Integrity = "sha512-jnSuA4Ss2PkkikSOLtYs8BlYIeeIK1h99ty4YfvRPAlzr377vr3CXDb7sb7eEEBYjDtcYj+AjBH3FLv5uSJuXg==", CrossOrigin = "anonymous" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/Theme.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/css/styles.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/icons/style.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/vendors/swiper/package/swiper-bundle.min.css" },
                
                
                new Resource { ResourceType = ResourceType.Script, Url = "~/vendors/jquery/jquery-2.2.4.min.js" },
                new Resource { ResourceType = ResourceType.Script, Url = "https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.3/js/bootstrap.bundle.min.js", Integrity = "sha512-7Pi/otdlbbCR+LnW+F7PwFcSDJOuUJB3OxtEHbg4vSMvzvJjde4Po1v4BR9Gdc9aXNUNFVUY+SK51wWT8WF0Gg==", CrossOrigin = "anonymous" },
                new Resource { ResourceType = ResourceType.Script, Url = "~/vendors/swiper/package/swiper-bundle.min.js" },
                new Resource { ResourceType = ResourceType.Script, Url = "~/js/main.js" },
            }
        };

    }
}
