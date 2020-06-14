using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name) : this()
        {
            Name = name;
        }

        public Job(string name, Employer e, Location l, PositionType p, CoreCompetency c) : this()
        {
            Name = name;
            EmployerName = e;
            EmployerLocation = l;
            JobType = p;
            JobCoreCompetency = c;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (Name == null && EmployerName == null & EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                return "OOPS! This job does not seem to exist.";
            }
            if(Name == "" || Name == null)
            {
                Name = "Data not available";
            }
            if(EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == "" || JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data not available";
            }

            string output = $"\nID:   {Id}\nName:   {Name}\nEmployer:   {EmployerName.Value}\nLocation:   {EmployerLocation.Value}\nPosition Type:   {JobType.Value}\nCore Competency:   {JobCoreCompetency.Value}\n";

            return output;
            /*string[] toStringReturnArray = { EmployerName.ToString(), EmployerLocation.ToString(), JobType.ToString(), JobCoreCompetency.ToString() };
            if (Name == null && toStringReturnArray[0] == "" && toStringReturnArray[1] == "" && toStringReturnArray[2] == "" && toStringReturnArray[3] == "")
            {
                return "OOPS! This job does not seem to exist.";
            }
            else
            {
                List<string> toStringReturns = new List<string>(); 
                foreach (string str in toStringReturnArray)
                {
                    if(str == "" || str == null)
                    {
                        toStringReturns.Add("Data not available");
                    }
                    else
                    {
                        toStringReturns.Add(str);
                    }
                }
                return "\n" + "ID:   " + Id + "\nName:   " + Name + "\nEmployer:   " + toStringReturns[0] + "\nLocation:   " + toStringReturns[1] + "\nPosition Type:   "
                    + toStringReturns[2] + "\nCore Competency:   " + toStringReturns[3] + "\n";
            }*/
        }

    }
}
