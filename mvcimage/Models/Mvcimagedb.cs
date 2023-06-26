namespace mvcimage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Mvcimagedb")]
    public partial class Mvcimagedb
    {
        [Key]
        public int imgid { get; set; }

        [StringLength(10)]
        [DisplayName("Title")]
        public string title { get; set; }
        [DisplayName("Uploaded image")]

        public string imgpath { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
