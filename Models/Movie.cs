using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]//DataType特性制定了数据的类型（Date）.通过此特性：用户无需再数据字段中输入时间信息  仅显示日期，而非时间信息
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Decription { get; set; }
    }
}
