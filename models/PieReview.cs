namespace Models
{
    public class PieReview
    {
        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace YourProjectName.Models
{
    public class PieReview
    {
        public int PieReviewId { get; set; }

        [Required]
        public string ReviewerName { get; set; }

        [Required]
        public string ReviewText { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public DateTime ReviewDate { get; set; }

        // Lidhja me Pie (foreign key)
        public int PieId { get; set; }
        public Pie Pie { get; set; }
    }
}