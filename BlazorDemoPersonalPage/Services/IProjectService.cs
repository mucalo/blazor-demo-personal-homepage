using BlazorDemoPersonalPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoPersonalPage.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetProjects();
    }
}
