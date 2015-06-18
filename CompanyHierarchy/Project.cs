using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public enum ProjectState{ Open,Closed }
    public class Project
    {
        public Project(string projectName, DateTime projectStartDate, string projectDetails, ProjectState projectState)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.ProjectDetails = projectDetails;
            this.ProjectState = projectState;
        }

        public ProjectState ProjectState { get; set; }

        public string ProjectDetails { get; set; }

        public DateTime ProjectStartDate { get; set; }

        public string ProjectName { get; set; }
    }
}
