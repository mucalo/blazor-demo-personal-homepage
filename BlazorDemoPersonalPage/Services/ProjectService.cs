using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemoPersonalPage.Models;

namespace BlazorDemoPersonalPage.Services
{
    public class ProjectService : IProjectService
    {
        public async Task<List<Project>> GetProjects()
        {
            var projects = new List<Project>();
            projects.Add(new Project
            {
                ProjectTitle = "R&D work",
                Client = "Siemens (Croatia)",
                ProjectDescription = "Worked on several R&D projects connected to oil and gas industry. Under NDA.",
                Image = "/img/Siemens.jpg",
                Technologies = new List<string> { "#aspnetcore", "#angular" }
            });
            projects.Add(new Project
            {
                ProjectTitle = "Audience Toolbar",
                Client = "Which? LTD (UK)",
                ProjectDescription = "Built a Chrome extension that helps Which? editing team to optimize their page content for search engines.",
                Image = "/img/Which.jpg",
                Technologies = new List<string> { "#aspnetcore", "#angular", "#chromeextensions" },
                Link = "www.intellegens.hr"
            });
            projects.Add(new Project
            {
                ProjectTitle = "Aircash",
                Client = "Aircash",
                ProjectDescription = "Helped build the prototype of the Aircash payment platform. Helped connect the system to initial partner solutions.",
                Image = "/img/Aircash.jpg",
                Link = "https://aircash.eu",
                Technologies = new List<string>() { "#aspnetcore", "#angular", "#mssqlserver" }
            });

            return await Task.FromResult(projects);
        }
    }
}
