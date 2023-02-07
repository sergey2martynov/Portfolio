using AndreysPortfolio.Interfaces;

namespace AndreysPortfolio.Models
{
    public class ProjectsHolder : IProjects
    {
        public IEnumerable<Project> Projects
        {
            get
            {
                return new List<Project>()
                {
                    new Project() { Name = "Ювелирная студия", Description = "D1", Image = "/img/1.jpg" },
                    new Project() { Name = "Бар", Description = "D2", Image = "/img/2.jpg" },
                    new Project() { Name = "Барбершоп", Description = "D3", Image = "/img/3.jpg" },
                    new Project() { Name = "Салон красоты", Description = "D4", Image = "/img/4.jpg" },
                    new Project() { Name = "Магазин майнинг оборудования", Description = "D5", Image = "/img/5.jpg" },
                    new Project() { Name = "Барбершоп", Description = "D6", Image = "/img/6.jpg" }
                };
            }
        }

        public IEnumerable<Project> GetProjects()
        {
            return Projects;
        }
    }
}
