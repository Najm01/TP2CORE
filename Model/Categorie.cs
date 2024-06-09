namespace TP2CORE.Model
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<sousCategorie> sousCategorie { get; set; }

        public Categorie()
        {
            sousCategorie = new List<sousCategorie>();
        }
    }

}
