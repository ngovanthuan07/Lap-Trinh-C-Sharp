using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai3
{
    class ManagerCandidate
    {
        List<Candidate> candidates;

        public ManagerCandidate()
        {
            this.candidates = new List<Candidate>();
        }

        public void add(Candidate candidate)
        {
            this.candidates.Add(candidate);
        }

        public void showInfor()
        {
            this.candidates.ForEach(candidate => Console.WriteLine(candidate.ToString()));
        }

        public Candidate searchById(String id)
        {
            return this.candidates.Find(candidate => candidate.getId().Equals(id));
        }
    }

    

}
