using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace lap3_TranHoangQuan_BigSchool.Models
{
    public class Following
    {
        public Course Course { get; set; }
        [Key]
        [Column(Order = 1)]
        public string FollowerId { get; set; }
        [Key]

        [Column(Order = 2)]
        public string FolloweeId { get; set; }

        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followee { get; set; }
    }
}