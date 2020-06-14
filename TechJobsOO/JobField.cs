using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string v) : this()
        {
            Value = v;
        }
        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (Value == null)
            {
                return "";
            }
            else
            {
                return Value;
            }
        }
    }
}
