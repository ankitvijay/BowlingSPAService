//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BowlingSPAService.Model.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Match
    {
        public Match()
        {
            this.Scores = new HashSet<Score>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Team1Id { get; set; }
        public Nullable<int> Team2Id { get; set; }
        public Nullable<System.DateTime> MatchDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
