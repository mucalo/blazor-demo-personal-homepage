using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemoPersonalPage.Models;

namespace BlazorDemoPersonalPage.Services
{
    public class ProjectService : IProjectService
    {
        public async Task<List<Article>> GetArticles()
        {
            var articles = new List<Article>();
            articles.Add(new Article
            {
                Title = "Building an one page website with server side Blazor",
                Link = "https://www.toptal.com/blog",
                Platform = "Toptal Engineering Blog"
            });
            articles.Add(new Article
            {
                Title = "Processes over Tools",
                Link = "https://www.linkedin.com/pulse/processes-over-tools-mario-mucalo/",
                Platform = "LinkedIn Articles"
            });
            articles.Add(new Article
            {
                Title = "Development blog",
                Link = "https://mariomucalo.com",
                Platform = "mariomucalo.com"
            });
            articles.Add(new Article
            {
                Title = "It only takes a minute to send minutes",
                Link = "https://steemit.com/remote/@mmucalo/it-only-takes-a-minute-to-send-minutes",
                Platform = "SteemIt"
            });

            return await Task.FromResult(articles);
        }

        public async Task<List<Project>> GetProjects()
        {
            var projects = new List<Project>();
            projects.Add(new Project
            {
                ProjectTitle = "R&D work",
                Client = "Siemens (Croatia)",
                ProjectDescription = "Worked on several R&D projects connected to oil and gas industry. Under NDA.",
                Image = "/img/Siemens.jpg",
                Technologies = new List<string> { "#aspnetcore", "#angular" },
                Link = "https://www.intellegens.hr/Home/Articles/intellegens-working-with-siemens-croatia"
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
                Link = "https://aircash.eu/en",
                Technologies = new List<string>() { "#aspnetcore", "#angular", "#mssqlserver" }
            });

            return await Task.FromResult(projects);
        }

        public async Task<List<Talk>> GetTalks()
        {
            var talks = new List<Talk>();

            talks.Add(new Talk
            {
                Event = "WebCamp",
                Title = "Debugging communication",
                Year = 2017,
                City = "Zagreb",
                Link = "https://2017.webcampzg.org/talks/debugging-communication/"
            });
            talks.Add(new Talk
            {
                Event = "Advanced Technology Days #13",
                City = "Zagreb",
                Year = 2017,
                Title = "Perception in remote environments",
                Link = "https://www.intellegens.hr/Home/Articles/MarioMucaloSpokeAtAdvancedTechnologyDays13"
            });
            talks.Add(new Talk
            {
                Event = "Remote Future Summit",
                Title = "Debugging communication",
                Year = 2018,
                City = "Online event",
                Link = "https://www.intellegens.hr/Home/Articles/MarioMucaloGaveTalkOnRemoteCommunicationAtRemoteFutureSummit"
            });
            talks.Add(new Talk
            {
                Event = "Toptal Coworking Day + Tech Talks",
                City = "Banja Luka",
                Year = 2019,
                Title = "Communication in remote environments - how not to get into trouble!",
                Link = "https://www.toptal.com/community/events/2019-06-27/toptal-coworking-day-tech-talks-banja-luka"
            });

            return await Task.FromResult(talks);
        }
    }
}
