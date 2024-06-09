namespace TP2CORE.Model
{
    public class sousCategorie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
    }

}
