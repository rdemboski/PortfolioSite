using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortfolioSite.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; } = [];

        public void OnGet()
        {
            Projects =
            [
                new Project
                {
                    Title = "Ellucian CRM Advance (Dynamics 365) Project",
                    Description = "Launched modern university-wide CRM solution with integration + automation to many internal and 3rd party systems.",
                    ImagePath = "/img/ellucian-logo.jpg",
                    AltText = "Ellucian CRM Advance",
                    Tags = ["ASP.NET", ".NET 8", "Azure", "OData/REST APIs"]
                },
                new Project
                {
                    Title = "Northern Arizona University IT Migration",
                    Description = "Migrated all on-prem infrastructure to Microsoft Azure. Migrated the existing development team to Azure DevOps for collaboration and version control.",
                    ImagePath = "/img/nau-logo.png",
                    AltText = "NAU",
                    Tags = ["Azure", "DevOps", "CI/CD", "Git"]
                },
                new Project
                {
                    Title = "Thermo King West Automation",
                    Description = "Automated large data entry process using .NET and Azure + Power Automate.",
                    ImagePath = "/img/tk-logo.png",
                    AltText = "Thermo King West",
                    Tags = [".NET 8", "Azure Functions", "Power Automate"]
                },
                new Project
                {
                    Title = "W.L. Gore & Associates Internship",
                    Description = "Developed MES system integration on an internal web application.",
                    ImagePath = "/img/gore-logo.jpg",
                    AltText = "W.L. Gore & Associates",
                    Tags = ["Camstar MES", "ASP.NET", "Web Forms"]
                },
                new Project
                {
                    Title = "Clover POS Device Integration",
                    Description = "Developed .NET solution for NAU to use Clover devices for fundraising and reporting dollars raised.",
                    ImagePath = "/img/clover-logo.png",
                    AltText = "Clover",
                    Tags = [".NET 8", "Azure Functions", "Clover REST API"]
                },
                new Project
                {
                    Title = "Sharepoint Setup + Integration",
                    Description = "Heavily involved in deploying NAU's sharepoint site. Developed automated sharepoint workflows with Microsoft Graph.",
                    ImagePath = "/img/sharepoint-logo.png",
                    AltText = "Clover",
                    Tags = ["Sharepoint", "Microsoft Graph", "Azure"]
                }
            ];
        }
    }

    public class Project
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? AltText { get; set; }
        public List<string>? Tags { get; set; }
    }
}