using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BizBloqs.Data.Entity
{
    [Table("StoredText", Schema = "Document")]
    public class StoredText
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreTextId { get; set; }
        [StringLength(20)]
        public string Data { get; set; }
        public DateTime CreatedOn { get; set; }

        public StoredText()
        {
            CreatedOn = DateTime.UtcNow;
        }
    }
}
