namespace MyShop.Web.Models
{
    public class PostTagViewModel
    {
        public int PosID { get; set; }

        public string TagID { get; set; }

        public virtual PostViewModel Post { get; set; }

        public virtual TagViewModel Tag { get; set; }
    }
}